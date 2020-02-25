
using UnityEngine;
using System.Collections.Generic;
using XLua;
using System;

namespace NXLua
{
    [System.Serializable]
    public class Injection
    {
        public string name;
        public GameObject value;
    }

    /// <summary>
    /// NINFO 这个类就是解决lua不能直接挂载成mono的问题
    /// 具体方法为
    /// 1 把这个mono类挂载到go
    /// 2 通过一个LuaTable scriptEnvTable，收集有关这个mono类的信息（mono实例，子节点go等）
    /// 3 Awake中通过一个string类型的path加载lua代码块时把这个scriptEnvTable传递过去
    /// </summary>

    [LuaCallCSharp]
    public class TLuaBehaviour : MonoBehaviour
    {
        public static Dictionary<string, LuaFunction> LuaDic = new Dictionary<string, LuaFunction>();
        //public TextAsset luaScript;
        //lua文件沙盒中相对位置,自定义loader再TLuaMgr中就已经设置好了，这类直接传入相对路径
        public string LuaRelePath;

        private bool BeLoadLuaStr = false;

        public Injection[] injections;

        public bool dontDestroyOnLoad;
        
        private Action luaStart;

        private Action luaUpdate;

        private Action luaOnDestroy;

        //这个lua表里会存储MonoBehaviour传给lua的一些参数
        //然后加载lua代码块时，会把这个表中传过去
        private LuaTable scriptEnvTable;

        public void Awake()
        {
            Debug.Log("TLuaBehaviour.Awake !");

            if (string.IsNullOrEmpty(LuaRelePath))
            {
                BeLoadLuaStr = false;
                Debug.Log("TLuaBehaviour.Awake LuaRelePath=null 不继续执行Awake");
                return;
            }

            
            Debug.Log("TLuaBehaviour.Awake LuaRelePath!=null 继续执行Awake");

            scriptEnvTable = TLuaMgr._LuaEnv.NewTable();

            // 为每个脚本设置一个独立的环境，可一定程度上防止脚本间全局变量、函数冲突
            // 具体看AfterLuaLoaded中对luaFunc.SetEnv(scriptEnvTable);的解释
            LuaTable meta = TLuaMgr._LuaEnv.NewTable();
            meta.Set("__index", TLuaMgr._LuaEnv.Global);

            //元表用来处理表之间的处理关系，比如这里meta表实现了__index,
            //当scriptEnvTable使用scriptEnvTable[xxx]找不到时，就会通过__index到TLuaMgr._LuaEnv.Global中查找
            scriptEnvTable.SetMetaTable(meta);
            meta.Dispose();

            //因为这句，暂时不能将所有lua统一从main.lua入口调用，在每个luaMono中单独调用
            //这句的意思时表scriptEnvTable就是TluaBehaviour，lua self相当与csharp中的this
            scriptEnvTable.Set("self", this);

            if (null != injections)
            {
                foreach (var injection in injections)
                {
                    scriptEnvTable.Set(injection.name, injection.value);
                }
            }
            Debug.Log("TLuaBehaviour.Awake 设置self 各种go环境完毕");

            //nafio info require加载的时候，后面的scriptEnv没生效，
            //但是直接加载str是生效的，要研究下怎么给一段lua设置环境
            //_LuaEnv.DoString(string.Format("require '{0}'",LuaRelePath)/*luaScript.text*/, "TLuaBehaviour", scriptEnv);
            //TLuaMgr._LuaEnv.DoString(s/*luaScript.text*/, "TLuaBehaviour", scriptEnv);

            //这样可以缓存lua代码段
            LuaFunction luaFunc = null;
            if (LuaDic.ContainsKey(LuaRelePath))
            {
                luaFunc = LuaDic[LuaRelePath];
                BeLoadLuaStr = true;
                AfterLuaLoaded(luaFunc);
            }
            else
            {
                //NTODO 这里如果从bundle加载，要做异步回调处理
                Debug.LogError("加载路径--->"+ LuaRelePath);
                TextAsset textAsset = Resources.Load<TextAsset>(LuaRelePath+".lua");
                Debug.LogError("加载到的txt--->" + textAsset.text);
                //先加载lua txt 然后再导入后续string,这里加载需要时间，是个异步操作
                //加载一个代码块，但不执行，只返回类型可以指定为一个delegate或者一个LuaFunction
                //第3个参数时这个代码块的环境变量
                luaFunc = TLuaMgr._LuaEnv.LoadString(textAsset.text, "TLuaBehaviour", scriptEnvTable);
                LuaDic.Add(LuaRelePath, luaFunc);
                AfterLuaLoaded(luaFunc);

            }

        }

        private void AfterLuaLoaded(LuaFunction luaFunc)
        {
            BeLoadLuaStr = true;

            //?这里和awake中重复了貌似
            //这里xlua的解释相当于lua的setfenv函数
            //setfenv的解释https://www.cnblogs.com/sifenkesi/p/3843348.html
            //猜测这句的意思就是为了避免luaFunc这段代码里面一些变量跟lua全局变量同名
            //给luaFunc这段代码设置了一个（非全局）环境(就是一个表)，
            //再直白点就是luaFunc只能访问这个非全局环境（表）中的域，或者自己函数本身的域
            //这里的意思就是lua代码段只能访问自己或者TluaBehaviour这个类
            luaFunc.SetEnv(scriptEnvTable);

            //执行lua代码段
            luaFunc.Call();

            //从lua代码段中取出名为awake的函数，？为什么能取到呢，表应该只包含TLuaBehaviour和lua.Globle,
            //怎么可以取到lua代码段中的代码呢，难道是从全局里取到的？
            Action luaAwake = scriptEnvTable.Get<Action>("awake");

            //从lua代码段中取出名为start的函数，并复制给luaStart这个委托，这样，通过这个委托，在Start中
            //就可以调用lua代码中的start了
            scriptEnvTable.Get("start", out luaStart);

            scriptEnvTable.Get("update", out luaUpdate);

            scriptEnvTable.Get("ondestroy", out luaOnDestroy);

            if (luaAwake != null)
            {
                luaAwake();
            }

        }

        public void Start()
        {

            Debug.Log("TLuaBehaviour.Start !");

            if (!BeLoadLuaStr)
            {
                Debug.Log("TLuaBehaviour.Start LuaRelePath=null 不继续执行Start");
                return;
            }

            Debug.Log("TLuaBehaviour.Start LuaRelePath!=null 继续执行Start");

            if (luaStart != null)
            {
                luaStart();
            }
        }
        
        void Update()
        {
            if (!BeLoadLuaStr)
            {
                return;
            }
            if (luaUpdate != null)
            {
                luaUpdate();
            }
            
        }

        void OnDestroy()
        {
            if (!BeLoadLuaStr)
            {
                return;
            }
            if (luaOnDestroy != null)
            {
                luaOnDestroy();
            }
            luaOnDestroy = null;
            luaUpdate = null;
            luaStart = null;
            scriptEnvTable.Dispose();
            injections = null;
        }


		#region 

		//nafio info 这个方法用来替换本类中TextAsset，改为动态加载的方式
//		public void TT(){
//			AssetBundle ab = AssetBundle.LoadFromFile("bundlePath");  
//			TextAsset textAsset = ab.LoadAsset<TextAsset>("name");  
//			if (textAsset == null)  
//			{  
//				LogSystem.DebugLog("decrypt. {0}包没这个文件: {1}", BundleManager.luaAbName, BundleManager.luaAbPath.ToLower());  
//				return null;  
//			}  
//			ab.Unload(false);  
//			byte[] data = textAsset.bytes;  
//			data = Util.Decrypt(data);  
//			LuaBehaviour.mCacheAb = AssetBundle.LoadFromMemory(data);  
//		}

		#endregion

    }


}

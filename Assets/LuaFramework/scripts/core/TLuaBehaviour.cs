
using UnityEngine;
using System.Collections;
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

        private LuaTable scriptEnvTable;

        //string s = 
        //    @"function start()" +
        //    "print('injected object', btn1)" +
        //    "end";

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
            LuaTable meta = TLuaMgr._LuaEnv.NewTable();
            meta.Set("__index", TLuaMgr._LuaEnv.Global);
            
            scriptEnvTable.SetMetaTable(meta);
            meta.Dispose();

            scriptEnvTable.Set("self", this);//因为这句，暂时不能将所有lua统一从main.lua入口调用，在每个luaMono中单独调用

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
                luaFunc = TLuaMgr._LuaEnv.LoadString(textAsset.text, "TLuaBehaviour", scriptEnvTable);
                LuaDic.Add(LuaRelePath, luaFunc);
                AfterLuaLoaded(luaFunc);

            }

        }

        private void AfterLuaLoaded(LuaFunction luaFunc)
        {
            BeLoadLuaStr = true;

            luaFunc.SetEnv(scriptEnvTable);

            luaFunc.Call();

            Action luaAwake = scriptEnvTable.Get<Action>("awake");

            scriptEnvTable.Get("start", out luaStart);

            scriptEnvTable.Get("update", out luaUpdate);

            scriptEnvTable.Get("ondestroy", out luaOnDestroy);

            if (luaAwake != null)
            {
                luaAwake();
            }

        }

        // Use this for initialization
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

        // Update is called once per frame
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

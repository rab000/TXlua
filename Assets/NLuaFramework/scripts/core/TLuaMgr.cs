using UnityEngine;
using XLua;
using System.IO;
using System;
//记录下需要整理完成的功能
//？c#所有调用lua的类应该统一到一个类中，并且要缓存，防止每次调用从全局表Get https://www.e-learn.cn/content/qita/788501
//xxxx ？要载入多少个lua，这些lua通过遍历获取到?通过main.lua来直接载入就行,不需要其他方法


namespace NXLua {

    public class TLuaMgr : MonoBehaviour
    {
        /// <summary>
        /// LuaEnv对应Lua虚拟机，全局唯一
        /// </summary>
        public static LuaEnv _LuaEnv;

        public static TLuaMgr Ins;

        /// <summary>
        /// 用于保存lua的require方法
        /// </summary>
        private Func<string, LuaTable> require;

        /// <summary>
        /// lua定时GC
        /// </summary>
        internal static float lastGCTime = 0;
        internal const float GCInterval = 1;//1 second 

        private void Awake()
        {
            Ins = this;

			DontDestroyOnLoad (gameObject);

            _LuaEnv = new LuaEnv();

            
            //注意这里可以写相对路径，一旦自己设置了自定义的loader后，貌似Resource中的main就找不到
            //这里比较奇怪，因为m构架里是能找到的
            //问题解决实际是能找到的，因为在自定义loader中打了error log而误以为找不到
            _LuaEnv.AddLoader(MyLoader);
            //_LuaEnv.DoString("require 'test/main'");

            require = _LuaEnv.Global.Get<Func<string, LuaTable>>("require");

            //nafio info c#接管lua的require方法实际可以考虑在代码中动态require

            //funcInvoke = Require("funcInvoke").Get<Func<object, object[], object>>("FuncInvoke");

            //nafio info main.lua的主要作用是require其他的uiLua，hotfixLua，
            //当c#有了Require方法后，初始调用main.lua其实是可有可无的
            //先从本地Resources中读，上面注掉的是从沙盒读
            _LuaEnv.DoString("require 'main'");
            
            
            //Debug.LogError("准备call main.lua");
            //TextAsset textAsset = Resources.Load<TextAsset>("main.lua");
            //LuaFunction luaFunc = _LuaEnv.LoadString(textAsset.text);
            //luaFunc.Call();
            //Debug.LogError("main.lua内容----"+textAsset.text);
            //_LuaEnv.DoString(textAsset.text);
            
        }

        //void OnDestroy()
        //{
        //    require = null;
        //    _LuaEnv.Dispose();
        //    _LuaEnv = null;
        //}

        ~TLuaMgr()
        {
            if (_LuaEnv != null)
            {
                _LuaEnv.Dispose();
                _LuaEnv = null;
            }
        }

        void Update()
        {
            if (Time.time - TLuaMgr.lastGCTime > GCInterval)
            {
                //清除Lua的未手动释放的LuaBase对象（比如：LuaTable， LuaFunction），以及其它一些事情。
                _LuaEnv.Tick();
                TLuaMgr.lastGCTime = Time.time;
            }
        }

        private byte[] MyLoader(ref string filePath)
        {
			string path = Application.persistentDataPath + "/" + filePath + ".lua.txt";
            //Debug.LogError("---------->path:"+path);
            //path:C:/Users/1/AppData/LocalLow/DefaultCompany/TXlua/main.lua.txt
            if (!File.Exists(path))
            {
                //这句没必要设置成error
                Debug.Log("警告TLuaMgr.MyLoader lua not exist path:" + path);
                return null;
            }
            else
            {
                string str = File.ReadAllText(path);
                return System.Text.Encoding.UTF8.GetBytes(str);
            }
            
        }

        /// <summary>
        /// 用于调用lua的require方法
        /// </summary>
        /// <param name="luaPath"></param>
        /// <returns></returns>
        public LuaTable Require(string luaPath)
        {
            try
            {
                return require(luaPath);
            }
            catch (LuaException le)
            {
                Debug.LogError(le.Message);
                return null;
            }
        }

    }

}


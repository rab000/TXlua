using System.IO;
using UnityEngine;
using System;
using XLua;

namespace NTXlua
{
    public class NTLuaMgr : MonoBehaviour
    {

        #region config
        private static string _LuaPersistPath;
        public static string LuaPersistPath
        {
            get
            {
                if (null == _LuaPersistPath)
                {
                    _LuaPersistPath = Application.persistentDataPath + "/lua/";
                }
                return _LuaPersistPath;
            }
        }
        #endregion

        #region var

        private LuaEnv luaEnv;
        
        private Func<string, LuaTable> requireFunc;

        private Func<object, object[], object> funcInvokeFunc;

        private float _lastGCTime = 0;

        //cg时间1s
        private const float GCInterval = 1;


        #endregion

        #region life

        private static NTLuaMgr Ins;

        public static NTLuaMgr GetIns()
        {
            return Ins;
        }

        public void Awake()
        {
            Ins = this;

            luaEnv = new LuaEnv();

            luaEnv.AddLoader(CustomLoader);

            requireFunc = luaEnv.Global.Get<Func<string, LuaTable>>("require");

            funcInvokeFunc = Require("NTFuncInvoke").Get<Func<object, object[], object>>("NTFuncInvoke");

            //通过main.lua预加载一些全局lua
            //通过main.lua调用hotfix.lua做热修复
            luaEnv.DoString("require 'main'");

        }

        //增加自定义读取位置的loader
        private byte[] CustomLoader(ref string fileName)
        {
            string filePath = LuaPersistPath + fileName + ".lua.txt";

            //Debug.LogError("CustomLoader filePath:"+filePath);

            if (File.Exists(filePath))
            {
                return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(filePath));
            }
            return null;
        }

        public void OnDestroy()
        {
            requireFunc = null;
            funcInvokeFunc = null;
        }

        //lua gc
        public void Update()
        {
            if (Time.time - _lastGCTime > GCInterval)
            {
                if (luaEnv != null)
                {
                    luaEnv.Tick();
                }
                _lastGCTime = Time.time;
            }
        }

        ~NTLuaMgr()
        {
            if (luaEnv != null)
            {
                luaEnv.Dispose();
                luaEnv = null;
            }
        }

        #endregion

        #region func

        public LuaEnv GetLuaEnv()
        {
            return luaEnv;
        }

        /// <summary>
        /// 获取lua代码段(块)的luaTable
        /// </summary>
        /// <param name="luaPath">绝对路径</param>
        /// <returns></returns>
        public LuaTable Require(string luaPath)
        {
            try
            {
                return requireFunc(luaPath);
            }
            catch (LuaException le)
            {
                Debug.LogError(le.Message);
                return null;
            }
        }

        public object FuncInvoke(object func, params object[] args)
        {
            try
            {
                return funcInvokeFunc(func, args);
            }
            catch (LuaException le)
            {
                Debug.LogError(le.Message);
                return null;
            }
        }

        #endregion

    }

}

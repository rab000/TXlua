using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;
using XLua;

namespace mplExtension
{
    public class LuaMgr : MonoBehaviour, IDisposable
    {
        private LuaEnv luaEnv;
        private Func<string, LuaTable> require;
        private Func<object, object[], object> funcInvoke;
        private float _lastGCTime = 0;
        /// <summary>
        /// 1 second
        /// </summary>
        private const float GCInterval = 1;

        public static LuaMgr Ins;

        public void Awake()
        {
            Ins = this;
            luaEnv = new LuaEnv();
            luaEnv.AddLoader(CustomLoader);
            require = luaEnv.Global.Get<Func<string, LuaTable>>("require");
            Require("clone");
            funcInvoke = Require("funcInvoke").Get<Func<object, object[], object>>("FuncInvoke");
        }
        private byte[] CustomLoader(ref string filepath)
        {
            filepath = filepath.Replace(".", "/");
            string file = Application.persistentDataPath + "/res/assets/" + filepath + ".lua.txt";
            if (File.Exists(file))
            {
                return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(file));
            }
            return null;
        }
        //~LuaMgr()
        //{
        //    if (luaEnv != null)
        //    {
        //        luaEnv.Dispose();
        //        luaEnv = null;
        //    }
        //}
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
        public LuaEnv GetLuaEnv()
        {
            return luaEnv;
        }

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
        public object FuncInvoke(object func, params object[] args)
        {
            try
            {
                return funcInvoke(func, args);
            }
            catch (LuaException le)
            {
                Debug.LogError(le.Message);
                return null;
            }
        }

        public void OnDestroy()
        {
            Dispose();
        }

        public void Dispose()
        {
            require = null;
            funcInvoke = null;
            luaEnv.Dispose();
            luaEnv = null;
        }
    }
}

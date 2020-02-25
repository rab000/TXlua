using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;
using XLua;

namespace mplExtension
{
    public class LuaMgr : MonoBehaviour
    {
        private LuaEnv luaEnv;
        //NINFO Func最后一个参数是返回类型，别混了
        //这个委托用来绑定lua的require方法返回代码段的LuaTable
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
        //nafio  这里写在析构而不写再OnDestroy中的原因
        //写到OnDestroy中会报错try to dispose a LuaEnv with C# callback!”
        //原因是此时c#还存在luaEnv的一些引用
        //析构函数会在OnDestroy完毕后过一会执行
        //同时unity中是不建议用析构的，在Awake前也会多次执行析构,所以这里要做非空判定
        
        ~LuaMgr()
        {
            if (luaEnv != null)
            {
                luaEnv.Dispose();
                luaEnv = null;
            }
        }
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
            require = null;
            funcInvoke = null;
        }
       

    }
}

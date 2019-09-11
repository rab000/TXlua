﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;

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
        /// lua定时GC
        /// </summary>
        internal static float lastGCTime = 0;
        internal const float GCInterval = 1;//1 second 

        private void Awake()
        {
            Ins = this;

			DontDestroyOnLoad (gameObject);

            _LuaEnv = new LuaEnv();

            //_LuaEnv.AddLoader(MyLoader);
            //注意这里可以写相对路径，一旦自己设置了自定义的loader后，貌似Resource中的main就找不到
            //_LuaEnv.DoString("require 'test/main'");

            //先从本地Resources中读，上面注掉的是从沙盒读
            _LuaEnv.DoString("require 'main'");
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
                Debug.LogError("TLuaMgr.MyLoader lua not exist path:" + path);
                return null;
            }
            else
            {
                string str = File.ReadAllText(path);
                return System.Text.Encoding.UTF8.GetBytes(str);
            }
            
        }

        public void Dispose()
        {
            _LuaEnv.Dispose();
            GameObject.Destroy(gameObject);
        }
    }

}


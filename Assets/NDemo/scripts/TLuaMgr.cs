using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;

namespace NXLua {

    public class TLuaMgr : MonoBehaviour
    {

        public static LuaEnv _LuaEnv = new LuaEnv();

        public static TLuaMgr Ins;

        private void Awake()
        {
            Ins = this;

            _LuaEnv.AddLoader(MyLoader);
        }

        void Start()
        {
            _LuaEnv.DoString(string.Format("package.path = '{0}/?.lua'", Application.dataPath));
        }

        private byte[] MyLoader(ref string filePath)
        {
            string absPath = @"E:appunity2018productsFishXlua" + filePath + ".lua.txt";
            return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(absPath));
        }
    }
}


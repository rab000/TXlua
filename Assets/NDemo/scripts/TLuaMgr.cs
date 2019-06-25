using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;

//记录下需要整理完成的功能
//？c#所有调用lua的类应该统一到一个类中，并且要缓存，防止每次调用从全局表Get https://www.e-learn.cn/content/qita/788501
//xxxx ？要载入多少个lua，这些lua通过遍历获取到?通过main.lua来直接载入就行,不需要其他方法

//NTODO 下一步，

namespace NXLua {

    public class TLuaMgr : MonoBehaviour
    {

        public static LuaEnv _LuaEnv = new LuaEnv();

        public static TLuaMgr Ins;

        private void Awake()
        {
            Ins = this;
			DontDestroyOnLoad (gameObject);
            TStart();
        }

		public void TStart()
		{
			_LuaEnv.AddLoader(MyLoader);
            //注意这里可以写相对路径，一旦自己设置了自定义的loader后，貌似Resource中的main就找不到
            _LuaEnv.DoString("require 'test/main'");
            
        }

        private byte[] MyLoader(ref string filePath)
        {
			string path = Application.persistentDataPath + "/" + filePath + ".lua.txt";
            //Debug.LogError("---------->path:"+path);
            //path:C:/Users/1/AppData/LocalLow/DefaultCompany/TXlua/main.lua.txt
    
            string str = File.ReadAllText (path);
			return System.Text.Encoding.UTF8.GetBytes (str);
        }

        public void Dispose()
        {
            _LuaEnv.Dispose();

            GameObject.Destroy(gameObject);
        }
    }

}


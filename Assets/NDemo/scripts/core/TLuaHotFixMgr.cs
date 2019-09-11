//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using NXLua;
//using System.IO;
///// <summary>
///// 热修复
///// </summary>
//public class TLuaHotFixMgr : MonoBehaviour {

//	void Awake(){
//		TLuaMgr._LuaEnv.AddLoader (MyLoader);   
//		//NTODO 这里貌似需要载入所有需要热更的lua,貌似这个类都不需要了，main.lua接管了

//		TLuaMgr._LuaEnv.DoString ("require 'hot'");
//	}

//	public byte[] MyLoader(ref string filepath) {
//		string path = Application.persistentDataPath + "/" + filepath + ".lua.txt";
//		string str = File.ReadAllText (path);
//		return System.Text.Encoding.UTF8.GetBytes (str);
//	}

//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NXLua;
using System.IO;
public class TLuaHotFixMgr : MonoBehaviour {

	void Awake(){
		TLuaMgr.Ins._LuaEnv.AddLoader (MyLoader);   
		//NTODO 这里貌似需要载入所有需要热更的lua
		TLuaMgr.Ins._LuaEnv.DoString ("require 'hot'");
	}

	public byte[] MyLoader(ref string filepath) {
		string path = Application.persistentDataPath + "/" + filepath + ".lua.txt";
		string str = File.ReadAllText (path);
		return System.Text.Encoding.UTF8.GetBytes (str);
	}

}

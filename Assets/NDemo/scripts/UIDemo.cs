using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NXLua;
using XLua;
public class UIDemo : MonoBehaviour {


    [CSharpCallLua]
    public delegate int FDelegate(GameObject go, string luaScriptName, bool beDestroy);

    void Start ()
    {
		
	}
	
    //某时某刻窗口能动态处理么
	
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            //动态添加一个go，动态绑定lua到这个go
            FDelegate f = TLuaMgr._LuaEnv.Global.Get<FDelegate>("AddLuaBehaviour");
            GameObject go = new GameObject("tGo");
            f(go,"tlua_ui_demo",false);
        }

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NXLua;
using XLua;
public class UIDemo : MonoBehaviour {


    [SerializeField] Transform CanvasTrm;

    [CSharpCallLua]
    public delegate int FDelegate(GameObject go, string luaScriptName, bool beDestroy);

    void Awake()
    {
        
        CanvasTrm = GameObject.Find("Canvas").transform;
    }

    //某时某刻窗口能动态处理么
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            //动态添加一个go，动态绑定lua到这个go，这个过程完全可以在lua中做
            //FDelegate f = TLuaMgr._LuaEnv.Global.Get<FDelegate>("AddLuaBehaviour");
            //GameObject go = new GameObject("newGo");
            //f(go,"tmono_ui",false);

            OpenUIWin("test_ui_panel");

        }

    }

    //通过一个窗口(prefab名称)就可以完成lua及对应prefab加载
    private void OpenUIWin(string winName)
    {
        
        //prefab上已经配置好了luaStr和要调用的go引用
        var go = GameObject.Instantiate( Resources.Load(winName)) as GameObject;

        go.transform.SetParent(CanvasTrm,false);

    }
}

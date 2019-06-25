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
            //动态添加一个go，动态绑定lua到这个go，这个过程完全可以在lua中做
            FDelegate f = TLuaMgr._LuaEnv.Global.Get<FDelegate>("AddLuaBehaviour");
            GameObject go = new GameObject("newGo");
            f(go,"tmono_ui",false);



            //prefab,假设存在一个c#辅助类，lua怎么操作ui相关呢，lua尽量不操作c#
            //问题关键在于 luaMono获取不到子节点上的go，除非从prefab绑定，然后按顺序读取
            //最好是lua只操作click等返回，但不操作btn绑定

            //可以考虑c#写个方法registBtnClick("goname",luafunc);//这个可以避免lua操作unity对象
            //这个方法的缺点是必须加到luaMono中，因为只有在这里才能拿到对应名称go的引用
            //luaMono中方法加多了就会很臃肿

            //NTODO 下一步，想下，lua怎么动态替换ui，怎么加总入口

            //NTODO  ui里面的btn等go如何传递到lua中，还是在c#端封装好

            //NTODO 关于lua元表与环境

            //NTODO 动态加载一个绑定了luaMono的prefab

            //下一步，具体lua ui mono类写法，
            //配置列表的写法
            //hotfix
            //后续逐步补充

        }

	}
}

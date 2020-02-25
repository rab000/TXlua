using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
namespace NTHotfix
{
    //这个标签不加lua会报错，LuaException: xlua.access, no field __Hotfix0_Show
    //或者添加白名单也行
    //[Hotfix]
    public class CSharpMono4Hotfix : MonoBehaviour
    {

        public static CSharpMono4Hotfix Ins;

        void Awake()
        {
            Ins = this;
        }

        public void Show()
        {
            Debug.Log("CSharp logic!!! AAA");
        }
    }
}


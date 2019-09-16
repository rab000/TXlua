using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mplExtension;
public class TestLuaUI : LuaBase
{
    public mplExtension.Injection[] Injections;

    public override object[] AfterAwakeInitLua()
    {
        object[] vs = new object[1];
        vs[0] = "TestLuaUI";     
        //TODO 做其他awake相关操作
        return vs;
    }

    public override void Awake()
    {
        base.Awake();
    }

    public override string GetLuaPath()
    {
        return "TestLuaUI";
    }

    public override MonoBehaviour GetThis()
    {
        return this;
    }

    public override Injection[] RegistObj()
    {
        return Injections;
    }

}

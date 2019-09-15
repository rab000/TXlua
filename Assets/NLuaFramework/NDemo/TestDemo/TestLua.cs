using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
/// <summary>
/// 用于测试xlua语法
/// </summary>
public class TestLua : MonoBehaviour
{
       


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("aaa");

            LuaEnv _lua = new LuaEnv();

            _lua.DoString("require 'testlua'");

            _lua.Dispose();
        }

    }
}

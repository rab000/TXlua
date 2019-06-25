using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
/// <summary>
/// 这里写lua调用unity的常用方法
/// </summary>
public class TLuaHelper  {

    public static void RegistBtnClick(GameObject go,Action onclick)
    {
        //go.GetComponent<Button>().onClick.AddListener(onclick);
    }
}

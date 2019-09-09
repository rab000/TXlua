using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NXLua;
using NTHotfix;
public class HotfixDemo : MonoBehaviour
{
    public void Start()
    {
       
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("开始执行");
            CSharpMono4Hotfix.Ins.Show();
        }

        
    }

}

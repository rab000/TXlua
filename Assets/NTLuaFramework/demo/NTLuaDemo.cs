using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NTLuaDemo : MonoBehaviour
{
    public Transform CanvasTrm;
    
    void Start()
    {
        
    }
   
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("启动一个可热更ui界面");

            OpenUI("NTUITest");

        }
    }


    public void OpenUI(string uiWinName)
    {
        var go = GameObject.Instantiate<GameObject>( Resources.Load<GameObject>(uiWinName));

        go.transform.SetParent(CanvasTrm,false);

        
    }


}

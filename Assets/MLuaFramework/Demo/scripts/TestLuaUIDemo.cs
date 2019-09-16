using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLuaUIDemo : MonoBehaviour
{
    public Transform CanvasTrm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            var go = GameObject.Instantiate(Resources.Load("TestLuaUI")) as GameObject;

            go.transform.SetParent(CanvasTrm);
            
        }

    }
}

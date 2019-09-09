using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
namespace NTHotfix
{
    [Hotfix]
    public class CSharpMono4Hotfix : MonoBehaviour
    {

        public static CSharpMono4Hotfix Ins;

        void Awake()
        {
            Ins = this;
        }

        void Start()
        {
            //Debug.Log("CSharp logic!!!");
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                Show();               
            }
        }

        public void Show()
        {
            Debug.Log("CSharp logic!!! AAA");
        }
    }
}


/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;

namespace NXLua
{
    [System.Serializable]
    public class Injection
    {
        public string name;
        public GameObject value;
    }

    [LuaCallCSharp]
    public class TLuaBehaviour : MonoBehaviour
    {
        //public TextAsset luaScript;
        //lua文件沙盒中相对位置,自定义loader再TLuaMgr中就已经设置好了，这类直接传入相对路径
        public string LuaRelePath;
        private bool BeLoadLuaStr = false;
        public Injection[] injections;
        public bool dontDestroyOnLoad;
        //internal static LuaEnv luaEnv = new LuaEnv(); //all lua behaviour shared one luaenv only!
        internal static float lastGCTime = 0;
        internal const float GCInterval = 1;//1 second 

        private Action luaStart;
        private Action luaUpdate;
        private Action luaOnDestroy;

        private LuaTable scriptEnv;

        string s = 
            @"function start()" +
            "print('injected object', btn1)" +
            "end";

        public void Awake()
        {
            Debug.Log("TLuaBehaviour.Awake !");

            if (string.IsNullOrEmpty(LuaRelePath))
            {
                BeLoadLuaStr = false;
                Debug.Log("TLuaBehaviour.Awake LuaRelePath=null 不继续执行Awake");
                return;
            }

            BeLoadLuaStr = true;
            Debug.Log("TLuaBehaviour.Awake LuaRelePath!=null 继续执行Awake");

            scriptEnv = TLuaMgr._LuaEnv.NewTable();
           
            // 为每个脚本设置一个独立的环境，可一定程度上防止脚本间全局变量、函数冲突
            LuaTable meta = TLuaMgr._LuaEnv.NewTable();
            meta.Set("__index", TLuaMgr._LuaEnv.Global);
            
            scriptEnv.SetMetaTable(meta);
            meta.Dispose();

            scriptEnv.Set("self", this);//因为这句，暂时不能将所有lua统一从main.lua入口调用，在每个luaMono中单独调用

            if (null != injections)
            {
                foreach (var injection in injections)
                {
                    scriptEnv.Set(injection.name, injection.value);
                }
            }
            Debug.Log("TLuaBehaviour.Awake 设置self 各种go环境完毕");

            //NTODO 下一步 ，require加载的时候，后面的scriptEnv没生效，要研究下怎么给一段lua设置环境
            //_LuaEnv.DoString(string.Format("require '{0}'",LuaRelePath)/*luaScript.text*/, "TLuaBehaviour", scriptEnv);
            TLuaMgr._LuaEnv.DoString(s/*luaScript.text*/, "TLuaBehaviour", scriptEnv);

            Action luaAwake = scriptEnv.Get<Action>("awake");
            scriptEnv.Get("start", out luaStart);
            scriptEnv.Get("update", out luaUpdate);
            scriptEnv.Get("ondestroy", out luaOnDestroy);

            if (luaAwake != null)
            {
                luaAwake();
            }
        }

        // Use this for initialization
        public void Start()
        {

            Debug.Log("TLuaBehaviour.Start !");

            if (!BeLoadLuaStr)
            {
                Debug.Log("TLuaBehaviour.Start LuaRelePath=null 不继续执行Start");
                return;
            }

            Debug.Log("TLuaBehaviour.Start LuaRelePath!=null 继续执行Start");

            if (luaStart != null)
            {
                luaStart();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (!BeLoadLuaStr)
            {
                return;
            }
            if (luaUpdate != null)
            {
                luaUpdate();
            }
            if (Time.time - TLuaBehaviour.lastGCTime > GCInterval)
            {
                TLuaMgr._LuaEnv.Tick();
                TLuaBehaviour.lastGCTime = Time.time;
            }
        }

        void OnDestroy()
        {
            if (!BeLoadLuaStr)
            {
                return;
            }
            if (luaOnDestroy != null)
            {
                luaOnDestroy();
            }
            luaOnDestroy = null;
            luaUpdate = null;
            luaStart = null;
            scriptEnv.Dispose();
            injections = null;
        }


		#region 

		//nafio info 这个方法用来替换本类中TextAsset，改为动态加载的方式
//		public void TT(){
//			AssetBundle ab = AssetBundle.LoadFromFile("bundlePath");  
//			TextAsset textAsset = ab.LoadAsset<TextAsset>("name");  
//			if (textAsset == null)  
//			{  
//				LogSystem.DebugLog("decrypt. {0}包没这个文件: {1}", BundleManager.luaAbName, BundleManager.luaAbPath.ToLower());  
//				return null;  
//			}  
//			ab.Unload(false);  
//			byte[] data = textAsset.bytes;  
//			data = Util.Decrypt(data);  
//			LuaBehaviour.mCacheAb = AssetBundle.LoadFromMemory(data);  
//		}

		#endregion

    }


}

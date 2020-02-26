using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using XLua;

namespace mplExtension
{
    [System.Serializable]
    public class Injection
    {
        public string name;
        public GameObject value;
    }
    public class LuaBehaviour : MonoBehaviour, IDisposable
    {
        private string LuaPath;
        private Injection[] Injections;

        private LuaTable luaTable;
        private Action<LuaTable> awake;
        private Action<LuaTable> start;
        private Action<LuaTable> onDestroy;

        private Action<LuaTable, string> onlanguageChange;
        private Action<LuaTable, object, string[]> onOpen;
        private Action<LuaTable> onOpenEnd;
        private Func<LuaTable, object> onClose;
        private Action<LuaTable> onCloseEnd;
        private Action<LuaTable> onRefresh;

        private Action<LuaTable, bool> updateSelectedView;

        private HashSet<IDisposable> behaviourListenerSet = new HashSet<IDisposable>();

        public LuaTable GetLuaTable()
        {
            return luaTable;
        }

        /// <summary>
        /// 相对于assetbundle的path
        /// </summary>
        /// <param name="path"></param>
        public virtual void SetLuaPath(string path)
        {
            LuaPath = path;
        }
        /// <summary>
        /// 像lua中注册unity对象
        /// </summary>
        /// <param name="injections"></param>
        public virtual void SetInjection(Injection[] injections)
        {
            Injections = injections;
        }
        /// <summary>
        /// 初始化lua（在上两部完成之后执行）
        /// </summary>
        /// <param name="args"></param>
        public virtual void InitLua(params object[] args)
        {
            //LuaBehaviour.InitLua i:0 arg:UIMail

            //for (int i = 0; i < args.Length; i++)
            //{
            //    Debug.LogError("LuaBehaviour.InitLua i:"+i+" arg:"+ args[i]);
            //}

            if (!string.IsNullOrEmpty(LuaPath))
            {
                Debug.LogError("开始处理原始表 luaPath:"+ LuaPath);

                //这个就是替代mono ui的lua代码段，在demo里就是TestLuaUI.lua.txt
                LuaTable luaClassTable = LuaMgr.Ins.Require(LuaPath);
                Debug.LogError("处理原始表 luaPath:" + LuaPath+" 完毕");
                if (luaClassTable != null)
                {
                    //看懂下面这句需要看两部分
                    //1 funcInvoke的意思，这个在funcInvoke.lua.txt中
                    //2 LuaClass.__call,funcInvoke的最后，将参数args转换成多个单独的参数，然后直接luaClassTable（p1,p2,p3）
                    //  这个函数调用是通过luaClass.__call实现的
                    
                    //得到的luaTable是什么呢，看luaClass.__call得知
                    //这个luaTable只是对luaClassTable做了一层包裹，有点坑，传入的args只是接收了，但是没做任何处理
                    //1 通过luaTable.__index可以访问到luaClassTable
                    //2 luaTable中加入了一些__index参数，实际也没用到
                    
                    //这个表luaTable和luaClassTable作用其实是一样的，就是csharp拿到了lua的引用，可以调用lua函数了
                    luaTable = LuaMgr.Ins.FuncInvoke(luaClassTable, args) as LuaTable;

                    if (luaTable != null)
                    {
                        OnTableInjection();
                        if (awake != null)
                        {
                            awake(luaTable);
                        }
                    }
                    else
                    {
                        Debug.LogError("The LuaObject is not instanced:" + LuaPath);
                    }
                }
                else
                {
                    Debug.LogError("The LuaTable is not returned:" + LuaPath);
                }
            }
            else
            {
                Debug.LogError("The LuaPath is Null!");
            }
        }

        public virtual void MplOnlanguageChange(string type)
        {
            if (onlanguageChange != null)
            {
                onlanguageChange(luaTable, type);
            }
        }
        public virtual void MplOnOpen(object obj = null, params string[] param)
        {
            if (onOpen != null)
            {
                onOpen(luaTable, obj, param);
            }
        }
        public virtual void MplOnOpenEnd()
        {
            if (onOpenEnd != null)
            {
                onOpenEnd(luaTable);
            }
        }

        public virtual void MplOnCloseEnd()
        {
            if (onCloseEnd != null)
            {
                onCloseEnd(luaTable);
            }
        }

        public virtual object MplOnClose()
        {
            if (onClose != null)
            {
                return onClose(luaTable);
            }
            return null;
        }

        public virtual void MplRefresh()
        {
            if (onRefresh != null)
            {
                onRefresh(luaTable);
            }
        }

        public virtual void SetThis(MonoBehaviour mono)
        {
            luaTable.Set("cs_behaviour", mono);
        }
        public virtual void SetData(object data)
        {
            luaTable.Set("cs_data", data);
        }
        protected virtual void OnTableInjection()
        {
            SetThis(this);

            foreach (var injection in Injections)
            {
                luaTable.Set(injection.name, injection.value);
            }

            awake = luaTable.Get<Action<LuaTable>>("Awake");
            start = luaTable.Get<Action<LuaTable>>("Start");
            onDestroy = luaTable.Get<Action<LuaTable>>("OnDestroy");

            onlanguageChange = luaTable.Get<Action<LuaTable, string>>("MplOnlanguageChange");
            onOpen = luaTable.Get<Action<LuaTable, object, string[]>>("MplOnOpen");
            onOpenEnd = luaTable.Get<Action<LuaTable>>("MplOnOpenEnd");
            onClose = luaTable.Get<Func<LuaTable, object>>("MplOnClose");
            onCloseEnd = luaTable.Get<Action<LuaTable>>("MplOnCloseEnd");
            onRefresh = luaTable.Get<Action<LuaTable>>("MplRefresh");

            updateSelectedView = luaTable.Get<Action<LuaTable, bool>>("MplUpdateSelectedView");

            //NINFO 使用这些listener的作用是当lua中有这些需求时才动态挂载这些功能，如果直接挂载上空跑很浪费性能
            AddUpdateListener();
            AddFixedUpdateListener();
            AddLateUpdateListener();
            AddApplicationListener();
            AddEnabledListener();
            AddPhysicsListener();
            AddGUIListener();
        }
        private void AddUpdateListener()
        {
            Action<LuaTable> luaUpdate = luaTable.Get<Action<LuaTable>>("Update");
            if (luaUpdate != null)
            {
                UpdateListener listener = UpdateListener.Get(this);
                listener.update = luaUpdate;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }

        private void AddFixedUpdateListener()
        {
            Action<LuaTable> luaFixedUpdate = luaTable.Get<Action<LuaTable>>("FixedUpdate");
            if (luaFixedUpdate != null)
            {
                FixedUpdateListener listener = FixedUpdateListener.Get(this);
                listener.fixedUpdate = luaFixedUpdate;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }

        private void AddLateUpdateListener()
        {
            Action<LuaTable> luaLateUpdate = luaTable.Get<Action<LuaTable>>("LateUpdate");
            if (luaLateUpdate != null)
            {
                LateUpdateListener listener = LateUpdateListener.Get(this);
                listener.lateUpdate = luaLateUpdate;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }

        private void AddApplicationListener()
        {
            Action<LuaTable, bool> luaOnApplicationFocus = luaTable.Get<Action<LuaTable, bool>>("OnApplicationFocus");
            Action<LuaTable, bool> luaOnApplicationPause = luaTable.Get<Action<LuaTable, bool>>("OnApplicationPause");
            Action<LuaTable> luaOnApplicationQuit = luaTable.Get<Action<LuaTable>>("OnApplicationQuit");
            if (luaOnApplicationFocus != null || luaOnApplicationPause != null || luaOnApplicationQuit != null)
            {
                ApplicationListener listener = ApplicationListener.Get(this);
                listener.onApplicationFocus = luaOnApplicationFocus;
                listener.onApplicationPause = luaOnApplicationPause;
                listener.onApplicationQuit = luaOnApplicationQuit;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }

        private void AddPhysicsListener()
        {
            Action<LuaTable, Collision> luaOnCollisionEnter = luaTable.Get<Action<LuaTable, Collision>>("OnCollisionEnter");
            Action<LuaTable, Collision> luaOnCollisionExit = luaTable.Get<Action<LuaTable, Collision>>("OnCollisionExit");
            Action<LuaTable, Collision> luaOnCollisionStay = luaTable.Get<Action<LuaTable, Collision>>("OnCollisionStay");
            Action<LuaTable, Collider> luaOnTriggerEnter = luaTable.Get<Action<LuaTable, Collider>>("OnTriggerEnter");
            Action<LuaTable, Collider> luaOnTriggerExit = luaTable.Get<Action<LuaTable, Collider>>("OnTriggerExit");
            Action<LuaTable, Collider> luaOnTriggerStay = luaTable.Get<Action<LuaTable, Collider>>("OnTriggerStay");
            if (luaOnCollisionEnter != null || luaOnCollisionExit != null || luaOnCollisionStay != null ||
                luaOnTriggerEnter != null || luaOnTriggerExit != null || luaOnTriggerStay != null)
            {
                PhysicsListener listener = PhysicsListener.Get(this);
                listener.onCollisionEnter = luaOnCollisionEnter;
                listener.onCollisionExit = luaOnCollisionExit;
                listener.onCollisionStay = luaOnCollisionStay;
                listener.onTriggerEnter = luaOnTriggerEnter;
                listener.onTriggerExit = luaOnTriggerExit;
                listener.onTriggerStay = luaOnTriggerStay;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }

        private void AddEnabledListener()
        {
            Action<LuaTable> luaOnEnable = luaTable.Get<Action<LuaTable>>("OnEnable");
            Action<LuaTable> luaOnDisable = luaTable.Get<Action<LuaTable>>("OnDisable");
            if (luaOnEnable != null || luaOnDisable != null)
            {
                EnabledListener listener = EnabledListener.Get(this);
                listener.onEnable = luaOnEnable;
                listener.onDisable = luaOnDisable;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }

        private void AddGUIListener()
        {
            Action<LuaTable> luaOnGUI = luaTable.Get<Action<LuaTable>>("OnGUI");
            if (luaOnGUI != null)
            {
                GUIListener listener = GUIListener.Get(this);
                listener.onGUI = luaOnGUI;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }
        public virtual void Awake()
        {
        }

        public virtual void Start()
        {
            if (start != null)
            {
                start(luaTable);
            }
        }
        public virtual void OnDestroy()
        {
            if (onDestroy != null)
            {
                onDestroy(luaTable);
            }
            Dispose();
        }

        public virtual void Dispose()
        {
            awake = null;
            start = null;
            onDestroy = null;

            onlanguageChange = null;
            onOpen = null;
            onOpenEnd = null;
            onClose = null;
            onCloseEnd = null;
            onRefresh = null;

            updateSelectedView = null;

            foreach (IDisposable item in behaviourListenerSet)
            {
                item.Dispose();
            }
            behaviourListenerSet.Clear();

            if (luaTable != null)
            {
                luaTable.Dispose();
                luaTable = null;
            }
        }


        #region item
        public virtual void MplUpdateSelectedView(bool isSelected)
        {
            if (updateSelectedView != null)
            {
                updateSelectedView(luaTable, isSelected);
            }
        }
        #endregion
    }
}

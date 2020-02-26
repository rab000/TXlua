using System.Collections.Generic;
using UnityEngine;
using System;
using XLua;

namespace NTXlua
{
    [System.Serializable]
    public class Injection
    {
        public string name;
        public GameObject value;
    }

    public class NTLuaBehaviour : MonoBehaviour, IDisposable
    {
        #region var
        
        //lua文件统一放同一文件夹下，如果后续需要区分文件夹，可以生成一张luaFileName，到luaFileRelePath的表
        //这个在prefab上设置
        public string LuaFileName;

        //传入lua中的go，方便查找节点
        [SerializeField]private Injection[] Injections;


        //对应lua类
        private LuaTable luaTable;

        private Action<LuaTable> awake;

        private Action<LuaTable> start;

        private Action<LuaTable> onDestroy;

        /// <summary>
        /// 存储listener
        /// </summary>
        private HashSet<IDisposable> behaviourListenerSet = new HashSet<IDisposable>();

        #endregion
        
        #region life

        public virtual void Awake()
        {          
            object[] vs = new object[1];
            vs[0] = LuaFileName;
            InitLuaTable(vs);    
                        
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

        #endregion

        #region virtual

        /// <summary>
        /// 初始化luaTable
        /// </summary>
        /// <param name="args"></param>
        public virtual void InitLuaTable(params object[] args)
        {
            //string luaFilePath = NTLuaMgr.LuaPath + LuaFileName + ".lua.txt";

            if (!string.IsNullOrEmpty(LuaFileName))
            {
                //Debug.Log("luaFileName:"+ LuaFileName+" path:"+ luaFilePath);
                LuaTable luaClassTable = NTLuaMgr.GetIns().Require(LuaFileName);

                if (luaClassTable != null)
                {                    
                    luaTable = NTLuaMgr.GetIns().FuncInvoke(luaClassTable, args) as LuaTable;

                    if (luaTable != null)
                    {
                        AfterInitLuaTable();
                        if (awake != null)
                        {
                            awake(luaTable);
                        }
                    }
                    else
                    {
                        Debug.LogError("The LuaObject is not instanced:" + LuaFileName);
                    }
                }
                else
                {
                    Debug.LogError("The LuaTable is not returned:" + LuaFileName);
                }
            }
            else
            {
                Debug.LogError("The LuaPath is Null!");
            }
        }

        protected virtual void AfterInitLuaTable()
        {
            SetMono2Lua(this);

            foreach (var injection in Injections)
            {
                luaTable.Set(injection.name, injection.value);
            }

            awake = luaTable.Get<Action<LuaTable>>("Awake");
            start = luaTable.Get<Action<LuaTable>>("Start");
            onDestroy = luaTable.Get<Action<LuaTable>>("OnDestroy");

            //NINFO 使用这些listener的作用是当lua中有这些需求时才动态挂载这些功能，如果直接挂载上空跑很浪费性能
            AddUpdateListener();
            AddFixedUpdateListener();
            AddLateUpdateListener();
            AddApplicationListener();
            AddEnabledListener();
            //AddPhysicsListener();

        }

        public virtual void SetMono2Lua(MonoBehaviour mono)
        {
            luaTable.Set("cs_behaviour", mono);
        }

        
        #endregion

        #region public

        public LuaTable GetLuaTable()
        {
            return luaTable;
        }

        #endregion

        #region listener

        private void AddUpdateListener()
        {
            Action<LuaTable> luaUpdate = luaTable.Get<Action<LuaTable>>("Update");
            if (luaUpdate != null)
            {
                NTUpdateListener listener = NTUpdateListener.Get(this);
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
                NTFixedUpdateListener listener = NTFixedUpdateListener.Get(this);
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
                NTLateUpdateListener listener = NTLateUpdateListener.Get(this);
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
                NTApplicationListener listener = NTApplicationListener.Get(this);
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
                NTPhysicsListener listener = NTPhysicsListener.Get(this);
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
                NTEnabledListener listener = NTEnabledListener.Get(this);
                listener.onEnable = luaOnEnable;
                listener.onDisable = luaOnDisable;
                if (!behaviourListenerSet.Contains(listener))
                {
                    behaviourListenerSet.Add(listener);
                }
            }
        }

        #endregion

        

    }
}

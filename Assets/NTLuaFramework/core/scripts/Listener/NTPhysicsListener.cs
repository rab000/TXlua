using System;
using UnityEngine;
using XLua;

namespace NTXlua
{
    public class NTPhysicsListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable, Collision> onCollisionEnter;
        public Action<LuaTable, Collision> onCollisionExit;
        public Action<LuaTable, Collision> onCollisionStay;
        public Action<LuaTable, Collider> onTriggerEnter;
        public Action<LuaTable, Collider> onTriggerExit;
        public Action<LuaTable, Collider> onTriggerStay;
        private LuaTable luaTable;

        void Awake()
        {
            NTLuaBehaviour behaviour = gameObject.GetComponent<NTLuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void OnCollisionEnter(Collision collision)
        {
            if (onCollisionEnter != null)
            {
                onCollisionEnter(luaTable, collision);
            }
        }

        void OnCollisionExit(Collision collision)
        {
            if (onCollisionExit != null)
            {
                onCollisionExit(luaTable, collision);
            }
        }

        void OnCollisionStay(Collision collision)
        {
            if (onCollisionStay != null)
            {
                onCollisionStay(luaTable, collision);
            }
        }

        void OnTriggerEnter(Collider collider)
        {
            if (onTriggerEnter != null)
            {
                onTriggerEnter(luaTable, collider);
            }
        }

        void OnTriggerExit(Collider collider)
        {
            if (onTriggerExit != null)
            {
                onTriggerExit(luaTable, collider);
            }
        }

        void OnTriggerStay(Collider collider)
        {
            if (onTriggerStay != null)
            {
                onTriggerStay(luaTable, collider);
            }
        }

        private static NTPhysicsListener FindListener(NTPhysicsListener[] listeners, string listenerTag)
        {
            foreach (NTPhysicsListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static NTPhysicsListener Get(GameObject go, string listenerTag = null)
        {
            NTPhysicsListener[] listeners = go.GetComponents<NTPhysicsListener>();
            NTPhysicsListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<NTPhysicsListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static NTPhysicsListener Get(Component comp, string listenerTag = null)
        {
            return Get(comp.gameObject, listenerTag);
        }

        public void Dispose()
        {
            onCollisionEnter = null;
            onCollisionExit = null;
            onCollisionStay = null;
            onTriggerEnter = null;
            onTriggerExit = null;
            onTriggerStay = null;
            Destroy(this);
        }
    }

}
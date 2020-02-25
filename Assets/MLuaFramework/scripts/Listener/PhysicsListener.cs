using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace mplExtension
{
    public class PhysicsListener : MonoBehaviour, IDisposable
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
            LuaBehaviour behaviour = gameObject.GetComponent<LuaBehaviour>();
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

        private static PhysicsListener FindListener(PhysicsListener[] listeners, string listenerTag)
        {
            foreach (PhysicsListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static PhysicsListener Get(GameObject go, string listenerTag = null)
        {
            PhysicsListener[] listeners = go.GetComponents<PhysicsListener>();
            PhysicsListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<PhysicsListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static PhysicsListener Get(Component comp, string listenerTag = null)
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
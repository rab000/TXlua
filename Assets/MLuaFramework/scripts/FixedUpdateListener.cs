using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace mplExtension
{
    public class FixedUpdateListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> fixedUpdate;
        private LuaTable luaTable;

        void Awake()
        {
            LuaBehaviour behaviour = gameObject.GetComponent<LuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void FixedUpdate()
        {
            if (fixedUpdate != null)
            {
                fixedUpdate(luaTable);
            }
        }

        private static FixedUpdateListener FindListener(FixedUpdateListener[] listeners, string listenerTag)
        {
            foreach (FixedUpdateListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static FixedUpdateListener Get(GameObject go, string listenerTag = null)
        {
            FixedUpdateListener[] listeners = go.GetComponents<FixedUpdateListener>();
            FixedUpdateListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<FixedUpdateListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static FixedUpdateListener Get(Component comp, string listenerTag = null)
        {
            return Get(comp.gameObject, listenerTag);
        }

        public void Dispose()
        {
            fixedUpdate = null;
            Destroy(this);
        }
    }

}
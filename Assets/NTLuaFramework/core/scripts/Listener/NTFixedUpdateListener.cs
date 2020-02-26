using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace NTXlua
{
    public class NTFixedUpdateListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> fixedUpdate;
        private LuaTable luaTable;

        void Awake()
        {
            NTLuaBehaviour behaviour = gameObject.GetComponent<NTLuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void FixedUpdate()
        {
            if (fixedUpdate != null)
            {
                fixedUpdate(luaTable);
            }
        }

        private static NTFixedUpdateListener FindListener(NTFixedUpdateListener[] listeners, string listenerTag)
        {
            foreach (NTFixedUpdateListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static NTFixedUpdateListener Get(GameObject go, string listenerTag = null)
        {
            NTFixedUpdateListener[] listeners = go.GetComponents<NTFixedUpdateListener>();
            NTFixedUpdateListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<NTFixedUpdateListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static NTFixedUpdateListener Get(Component comp, string listenerTag = null)
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
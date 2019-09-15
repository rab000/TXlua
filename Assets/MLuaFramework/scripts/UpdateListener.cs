using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace mplExtension
{
    public class UpdateListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> update;
        private LuaTable luaTable;

        void Awake()
        {
            LuaBehaviour behaviour = gameObject.GetComponent<LuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void Update()
        {
            if (update != null)
            {
                update(luaTable);
            }
        }

        private static UpdateListener FindListener(UpdateListener[] listeners, string listenerTag)
        {
            foreach (UpdateListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static UpdateListener Get(GameObject go, string listenerTag = null)
        {
            UpdateListener[] listeners = go.GetComponents<UpdateListener>();
            UpdateListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<UpdateListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static UpdateListener Get(Component comp, string listenerTag = null)
        {
            return Get(comp.gameObject, listenerTag);
        }

        public void Dispose()
        {
            update = null;
            Destroy(this);
        }
    }

}
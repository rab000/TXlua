using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace mplExtension
{
    public class EnabledListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> onEnable;
        public Action<LuaTable> onDisable;
        private LuaTable luaTable;

        void Awake()
        {
            LuaBehaviour behaviour = gameObject.GetComponent<LuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void OnEnable()
        {
            if (onEnable != null)
            {
                onEnable(luaTable);
            }
        }

        void OnDisable()
        {
            if (onDisable != null)
            {
                onDisable(luaTable);
            }
        }

        private static EnabledListener FindListener(EnabledListener[] listeners, string listenerTag)
        {
            foreach (EnabledListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static EnabledListener Get(GameObject go, string listenerTag = null)
        {
            EnabledListener[] listeners = go.GetComponents<EnabledListener>();
            EnabledListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<EnabledListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static EnabledListener Get(Component comp, string listenerTag = null)
        {
            return Get(comp.gameObject, listenerTag);
        }

        public void Dispose()
        {
            onEnable = null;
            onDisable = null;
            Destroy(this);
        }
    }

}
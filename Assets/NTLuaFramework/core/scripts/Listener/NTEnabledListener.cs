using System;
using UnityEngine;
using XLua;

namespace NTXlua
{
    public class NTEnabledListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> onEnable;
        public Action<LuaTable> onDisable;
        private LuaTable luaTable;

        void Awake()
        {
            NTLuaBehaviour behaviour = gameObject.GetComponent<NTLuaBehaviour>();
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

        private static NTEnabledListener FindListener(NTEnabledListener[] listeners, string listenerTag)
        {
            foreach (NTEnabledListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static NTEnabledListener Get(GameObject go, string listenerTag = null)
        {
            NTEnabledListener[] listeners = go.GetComponents<NTEnabledListener>();
            NTEnabledListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<NTEnabledListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static NTEnabledListener Get(Component comp, string listenerTag = null)
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
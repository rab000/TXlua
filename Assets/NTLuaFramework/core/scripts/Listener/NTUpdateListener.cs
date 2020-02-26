using System;
using UnityEngine;
using XLua;

namespace NTXlua
{
    public class NTUpdateListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> update;
        private LuaTable luaTable;

        void Awake()
        {
            NTLuaBehaviour behaviour = gameObject.GetComponent<NTLuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void Update()
        {
            if (update != null)
            {
                update(luaTable);
            }
        }

        private static NTUpdateListener FindListener(NTUpdateListener[] listeners, string listenerTag)
        {
            foreach (NTUpdateListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static NTUpdateListener Get(GameObject go, string listenerTag = null)
        {
            NTUpdateListener[] listeners = go.GetComponents<NTUpdateListener>();
            NTUpdateListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<NTUpdateListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static NTUpdateListener Get(Component comp, string listenerTag = null)
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
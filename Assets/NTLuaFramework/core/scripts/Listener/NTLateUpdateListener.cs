using System;
using UnityEngine;
using XLua;

namespace NTXlua
{
    public class NTLateUpdateListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> lateUpdate;
        private LuaTable luaTable;

        void Awake()
        {
            NTLuaBehaviour behaviour = gameObject.GetComponent<NTLuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void LateUpdate()
        {
            if (lateUpdate != null)
            {
                lateUpdate(luaTable);
            }
        }

        private static NTLateUpdateListener FindListener(NTLateUpdateListener[] listeners, string listenerTag)
        {
            foreach (NTLateUpdateListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static NTLateUpdateListener Get(GameObject go, string listenerTag = null)
        {
            NTLateUpdateListener[] listeners = go.GetComponents<NTLateUpdateListener>();
            NTLateUpdateListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<NTLateUpdateListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static NTLateUpdateListener Get(Component comp, string listenerTag = null)
        {
            return Get(comp.gameObject, listenerTag);
        }

        public void Dispose()
        {
            lateUpdate = null;
            Destroy(this);
        }
    }

}
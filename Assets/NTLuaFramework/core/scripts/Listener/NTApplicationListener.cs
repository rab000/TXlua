using System;
using UnityEngine;
using XLua;

namespace NTXlua
{
    public class NTApplicationListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable, bool> onApplicationFocus;
        public Action<LuaTable, bool> onApplicationPause;
        public Action<LuaTable> onApplicationQuit;
        private LuaTable luaTable;

        void Awake()
        {
            NTLuaBehaviour behaviour = gameObject.GetComponent<NTLuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void OnApplicationFocus(bool isFocus)
        {
            if (onApplicationFocus != null)
            {
                onApplicationFocus(luaTable, isFocus);
            }
        }

        void OnApplicationPause(bool isPause)
        {
            if (onApplicationPause != null)
            {
                onApplicationPause(luaTable, isPause);
            }
        }

        void OnApplicationQuit()
        {
            if (onApplicationQuit != null)
            {
                onApplicationQuit(luaTable);
            }
        }

        private static NTApplicationListener FindListener(NTApplicationListener[] listeners, string listenerTag)
        {
            foreach (NTApplicationListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static NTApplicationListener Get(GameObject go, string listenerTag = null)
        {
            NTApplicationListener[] listeners = go.GetComponents<NTApplicationListener>();
            NTApplicationListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<NTApplicationListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static NTApplicationListener Get(Component comp, string listenerTag = null)
        {
            return Get(comp.gameObject, listenerTag);
        }

        public void Dispose()
        {
            onApplicationFocus = null;
            onApplicationPause = null;
            onApplicationQuit = null;
            Destroy(this);
        }
    }

}
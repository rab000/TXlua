using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace mplExtension
{
    public class ApplicationListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable, bool> onApplicationFocus;
        public Action<LuaTable, bool> onApplicationPause;
        public Action<LuaTable> onApplicationQuit;
        private LuaTable luaTable;

        void Awake()
        {
            LuaBehaviour behaviour = gameObject.GetComponent<LuaBehaviour>();
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

        private static ApplicationListener FindListener(ApplicationListener[] listeners, string listenerTag)
        {
            foreach (ApplicationListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static ApplicationListener Get(GameObject go, string listenerTag = null)
        {
            ApplicationListener[] listeners = go.GetComponents<ApplicationListener>();
            ApplicationListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<ApplicationListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static ApplicationListener Get(Component comp, string listenerTag = null)
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
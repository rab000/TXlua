using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace mplExtension
{
    public class GUIListener : MonoBehaviour, IDisposable
    {
        public string listenerTag;
        public Action<LuaTable> onGUI;
        private LuaTable luaTable;

        void Awake()
        {
            LuaBehaviour behaviour = gameObject.GetComponent<LuaBehaviour>();
            luaTable = behaviour ? behaviour.GetLuaTable() : null;
        }

        void OnGUI()
        {
            if (onGUI != null)
            {
                onGUI(luaTable);
            }
        }

        private static GUIListener FindListener(GUIListener[] listeners, string listenerTag)
        {
            foreach (GUIListener listener in listeners)
            {
                if (string.Equals(listener.listenerTag, listenerTag))
                {
                    return listener;
                }
            }
            return null;
        }

        public static GUIListener Get(GameObject go, string listenerTag = null)
        {
            GUIListener[] listeners = go.GetComponents<GUIListener>();
            GUIListener listener = FindListener(listeners, listenerTag);
            if (listener == null)
            {
                listener = go.AddComponent<GUIListener>();
                listener.listenerTag = listenerTag;
            }
            return listener;
        }

        public static GUIListener Get(Component comp, string listenerTag = null)
        {
            return Get(comp.gameObject, listenerTag);
        }

        public void Dispose()
        {
            onGUI = null;
            Destroy(this);
        }
    }

}
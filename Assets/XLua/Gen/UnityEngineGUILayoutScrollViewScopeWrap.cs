#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineGUILayoutScrollViewScopeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GUILayout.ScrollViewScope);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 2, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollPosition", _g_get_scrollPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "handleScrollWheel", _g_get_handleScrollWheel);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "handleScrollWheel", _s_set_handleScrollWheel);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) >= 2 && translator.Assignable<UnityEngine.Vector2>(L, 2) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3)))
				{
					UnityEngine.Vector2 _scrollPosition;translator.Get(L, 2, out _scrollPosition);
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
					
					UnityEngine.GUILayout.ScrollViewScope gen_ret = new UnityEngine.GUILayout.ScrollViewScope(_scrollPosition, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 4 && translator.Assignable<UnityEngine.Vector2>(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5)))
				{
					UnityEngine.Vector2 _scrollPosition;translator.Get(L, 2, out _scrollPosition);
					bool _alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 3);
					bool _alwaysShowVertical = LuaAPI.lua_toboolean(L, 4);
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
					
					UnityEngine.GUILayout.ScrollViewScope gen_ret = new UnityEngine.GUILayout.ScrollViewScope(_scrollPosition, _alwaysShowHorizontal, _alwaysShowVertical, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 4 && translator.Assignable<UnityEngine.Vector2>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && translator.Assignable<UnityEngine.GUIStyle>(L, 4) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5)))
				{
					UnityEngine.Vector2 _scrollPosition;translator.Get(L, 2, out _scrollPosition);
					UnityEngine.GUIStyle _horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUIStyle _verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
					
					UnityEngine.GUILayout.ScrollViewScope gen_ret = new UnityEngine.GUILayout.ScrollViewScope(_scrollPosition, _horizontalScrollbar, _verticalScrollbar, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && translator.Assignable<UnityEngine.Vector2>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4)))
				{
					UnityEngine.Vector2 _scrollPosition;translator.Get(L, 2, out _scrollPosition);
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
					
					UnityEngine.GUILayout.ScrollViewScope gen_ret = new UnityEngine.GUILayout.ScrollViewScope(_scrollPosition, _style, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 6 && translator.Assignable<UnityEngine.Vector2>(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.GUIStyle>(L, 5) && translator.Assignable<UnityEngine.GUIStyle>(L, 6) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 7) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 7)))
				{
					UnityEngine.Vector2 _scrollPosition;translator.Get(L, 2, out _scrollPosition);
					bool _alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 3);
					bool _alwaysShowVertical = LuaAPI.lua_toboolean(L, 4);
					UnityEngine.GUIStyle _horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUIStyle _verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 7);
					
					UnityEngine.GUILayout.ScrollViewScope gen_ret = new UnityEngine.GUILayout.ScrollViewScope(_scrollPosition, _alwaysShowHorizontal, _alwaysShowVertical, _horizontalScrollbar, _verticalScrollbar, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 7 && translator.Assignable<UnityEngine.Vector2>(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.GUIStyle>(L, 5) && translator.Assignable<UnityEngine.GUIStyle>(L, 6) && translator.Assignable<UnityEngine.GUIStyle>(L, 7) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 8) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 8)))
				{
					UnityEngine.Vector2 _scrollPosition;translator.Get(L, 2, out _scrollPosition);
					bool _alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 3);
					bool _alwaysShowVertical = LuaAPI.lua_toboolean(L, 4);
					UnityEngine.GUIStyle _horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUIStyle _verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUIStyle _background = (UnityEngine.GUIStyle)translator.GetObject(L, 7, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 8);
					
					UnityEngine.GUILayout.ScrollViewScope gen_ret = new UnityEngine.GUILayout.ScrollViewScope(_scrollPosition, _alwaysShowHorizontal, _alwaysShowVertical, _horizontalScrollbar, _verticalScrollbar, _background, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.ScrollViewScope constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GUILayout.ScrollViewScope gen_to_be_invoked = (UnityEngine.GUILayout.ScrollViewScope)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.scrollPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_handleScrollWheel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GUILayout.ScrollViewScope gen_to_be_invoked = (UnityEngine.GUILayout.ScrollViewScope)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.handleScrollWheel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_handleScrollWheel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GUILayout.ScrollViewScope gen_to_be_invoked = (UnityEngine.GUILayout.ScrollViewScope)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.handleScrollWheel = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

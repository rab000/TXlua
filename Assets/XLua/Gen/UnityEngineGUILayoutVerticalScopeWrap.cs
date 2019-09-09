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
    public class UnityEngineGUILayoutVerticalScopeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GUILayout.VerticalScope);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) >= 1 && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2)))
				{
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
					
					UnityEngine.GUILayout.VerticalScope gen_ret = new UnityEngine.GUILayout.VerticalScope(_options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 2 && translator.Assignable<UnityEngine.GUIStyle>(L, 2) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3)))
				{
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
					
					UnityEngine.GUILayout.VerticalScope gen_ret = new UnityEngine.GUILayout.VerticalScope(_style, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4)))
				{
					string _text = LuaAPI.lua_tostring(L, 2);
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
					
					UnityEngine.GUILayout.VerticalScope gen_ret = new UnityEngine.GUILayout.VerticalScope(_text, _style, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && translator.Assignable<UnityEngine.Texture>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4)))
				{
					UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
					
					UnityEngine.GUILayout.VerticalScope gen_ret = new UnityEngine.GUILayout.VerticalScope(_image, _style, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && translator.Assignable<UnityEngine.GUIContent>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4)))
				{
					UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
					
					UnityEngine.GUILayout.VerticalScope gen_ret = new UnityEngine.GUILayout.VerticalScope(_content, _style, _options);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.VerticalScope constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}

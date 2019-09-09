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
    public class UnityEngineGUILayoutUtilityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GUILayoutUtility);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRect", _m_GetRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLastRect", _m_GetLastRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAspectRect", _m_GetAspectRect_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUILayoutUtility gen_ret = new UnityEngine.GUILayoutUtility();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayoutUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _width = (float)LuaAPI.lua_tonumber(L, 1);
                    float _height = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _width, _height );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float _maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float _maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _minWidth, _maxWidth, _minHeight, _maxHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    float _width = (float)LuaAPI.lua_tonumber(L, 1);
                    float _height = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _width, _height, _style );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    float _width = (float)LuaAPI.lua_tonumber(L, 1);
                    float _height = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _width, _height, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float _maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float _maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _minWidth, _maxWidth, _minHeight, _maxHeight, _style );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float _maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float _maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _minWidth, _maxWidth, _minHeight, _maxHeight, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _content, _style );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    float _width = (float)LuaAPI.lua_tonumber(L, 1);
                    float _height = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _width, _height, _style, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float _maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float _maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _minWidth, _maxWidth, _minHeight, _maxHeight, _style, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetRect( _content, _style, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayoutUtility.GetRect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLastRect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetLastRect(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAspectRect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float _aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( _aspect );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    float _aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( _aspect, _style );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    float _aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( _aspect, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    float _aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( _aspect, _style, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayoutUtility.GetAspectRect!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}

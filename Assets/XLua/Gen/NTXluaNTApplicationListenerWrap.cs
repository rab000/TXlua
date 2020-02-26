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
    public class NTXluaNTApplicationListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(NTXlua.NTApplicationListener);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "listenerTag", _g_get_listenerTag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onApplicationFocus", _g_get_onApplicationFocus);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onApplicationPause", _g_get_onApplicationPause);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onApplicationQuit", _g_get_onApplicationQuit);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "listenerTag", _s_set_listenerTag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onApplicationFocus", _s_set_onApplicationFocus);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onApplicationPause", _s_set_onApplicationPause);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onApplicationQuit", _s_set_onApplicationQuit);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Get", _m_Get_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					NTXlua.NTApplicationListener gen_ret = new NTXlua.NTApplicationListener();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to NTXlua.NTApplicationListener constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Get_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string _listenerTag = LuaAPI.lua_tostring(L, 2);
                    
                        NTXlua.NTApplicationListener gen_ret = NTXlua.NTApplicationListener.Get( _go, _listenerTag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        NTXlua.NTApplicationListener gen_ret = NTXlua.NTApplicationListener.Get( _go );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Component>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Component _comp = (UnityEngine.Component)translator.GetObject(L, 1, typeof(UnityEngine.Component));
                    string _listenerTag = LuaAPI.lua_tostring(L, 2);
                    
                        NTXlua.NTApplicationListener gen_ret = NTXlua.NTApplicationListener.Get( _comp, _listenerTag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Component>(L, 1)) 
                {
                    UnityEngine.Component _comp = (UnityEngine.Component)translator.GetObject(L, 1, typeof(UnityEngine.Component));
                    
                        NTXlua.NTApplicationListener gen_ret = NTXlua.NTApplicationListener.Get( _comp );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NTXlua.NTApplicationListener.Get!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_listenerTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.listenerTag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onApplicationFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onApplicationFocus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onApplicationPause(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onApplicationPause);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onApplicationQuit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onApplicationQuit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_listenerTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.listenerTag = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onApplicationFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onApplicationFocus = translator.GetDelegate<System.Action<XLua.LuaTable, bool>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onApplicationPause(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onApplicationPause = translator.GetDelegate<System.Action<XLua.LuaTable, bool>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onApplicationQuit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTApplicationListener gen_to_be_invoked = (NTXlua.NTApplicationListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onApplicationQuit = translator.GetDelegate<System.Action<XLua.LuaTable>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

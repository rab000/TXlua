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
    public class NTXluaNTPhysicsListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(NTXlua.NTPhysicsListener);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 7, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "listenerTag", _g_get_listenerTag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCollisionEnter", _g_get_onCollisionEnter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCollisionExit", _g_get_onCollisionExit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCollisionStay", _g_get_onCollisionStay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTriggerEnter", _g_get_onTriggerEnter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTriggerExit", _g_get_onTriggerExit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTriggerStay", _g_get_onTriggerStay);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "listenerTag", _s_set_listenerTag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCollisionEnter", _s_set_onCollisionEnter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCollisionExit", _s_set_onCollisionExit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCollisionStay", _s_set_onCollisionStay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onTriggerEnter", _s_set_onTriggerEnter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onTriggerExit", _s_set_onTriggerExit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onTriggerStay", _s_set_onTriggerStay);
            
			
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
					
					NTXlua.NTPhysicsListener gen_ret = new NTXlua.NTPhysicsListener();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to NTXlua.NTPhysicsListener constructor!");
            
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
                    
                        NTXlua.NTPhysicsListener gen_ret = NTXlua.NTPhysicsListener.Get( _go, _listenerTag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        NTXlua.NTPhysicsListener gen_ret = NTXlua.NTPhysicsListener.Get( _go );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Component>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Component _comp = (UnityEngine.Component)translator.GetObject(L, 1, typeof(UnityEngine.Component));
                    string _listenerTag = LuaAPI.lua_tostring(L, 2);
                    
                        NTXlua.NTPhysicsListener gen_ret = NTXlua.NTPhysicsListener.Get( _comp, _listenerTag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Component>(L, 1)) 
                {
                    UnityEngine.Component _comp = (UnityEngine.Component)translator.GetObject(L, 1, typeof(UnityEngine.Component));
                    
                        NTXlua.NTPhysicsListener gen_ret = NTXlua.NTPhysicsListener.Get( _comp );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NTXlua.NTPhysicsListener.Get!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
            
            
                
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
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.listenerTag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCollisionEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onCollisionEnter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCollisionExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onCollisionExit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCollisionStay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onCollisionStay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTriggerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTriggerEnter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTriggerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTriggerExit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTriggerStay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTriggerStay);
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
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.listenerTag = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCollisionEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onCollisionEnter = translator.GetDelegate<System.Action<XLua.LuaTable, UnityEngine.Collision>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCollisionExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onCollisionExit = translator.GetDelegate<System.Action<XLua.LuaTable, UnityEngine.Collision>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCollisionStay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onCollisionStay = translator.GetDelegate<System.Action<XLua.LuaTable, UnityEngine.Collision>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onTriggerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onTriggerEnter = translator.GetDelegate<System.Action<XLua.LuaTable, UnityEngine.Collider>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onTriggerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onTriggerExit = translator.GetDelegate<System.Action<XLua.LuaTable, UnityEngine.Collider>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onTriggerStay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                NTXlua.NTPhysicsListener gen_to_be_invoked = (NTXlua.NTPhysicsListener)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onTriggerStay = translator.GetDelegate<System.Action<XLua.LuaTable, UnityEngine.Collider>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

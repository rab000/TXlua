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
    public class mplExtensionLuaBehaviourWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(mplExtension.LuaBehaviour);
			Utils.BeginObjectRegister(type, L, translator, 0, 17, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLuaTable", _m_GetLuaTable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLuaPath", _m_SetLuaPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInjection", _m_SetInjection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitLua", _m_InitLua);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MplOnlanguageChange", _m_MplOnlanguageChange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MplOnOpen", _m_MplOnOpen);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MplOnOpenEnd", _m_MplOnOpenEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MplOnCloseEnd", _m_MplOnCloseEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MplOnClose", _m_MplOnClose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MplRefresh", _m_MplRefresh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetThis", _m_SetThis);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetData", _m_SetData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Awake", _m_Awake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Start", _m_Start);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDestroy", _m_OnDestroy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MplUpdateSelectedView", _m_MplUpdateSelectedView);
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					mplExtension.LuaBehaviour gen_ret = new mplExtension.LuaBehaviour();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to mplExtension.LuaBehaviour constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLuaTable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        XLua.LuaTable gen_ret = gen_to_be_invoked.GetLuaTable(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLuaPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetLuaPath( _path );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInjection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    mplExtension.Injection[] _injections = (mplExtension.Injection[])translator.GetObject(L, 2, typeof(mplExtension.Injection[]));
                    
                    gen_to_be_invoked.SetInjection( _injections );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitLua(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object[] _args = translator.GetParams<object>(L, 2);
                    
                    gen_to_be_invoked.InitLua( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MplOnlanguageChange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.MplOnlanguageChange( _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MplOnOpen(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& translator.Assignable<object>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    string[] _param = translator.GetParams<string>(L, 3);
                    
                    gen_to_be_invoked.MplOnOpen( _obj, _param );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.MplOnOpen( _obj );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 0) 
                {
                    
                    gen_to_be_invoked.MplOnOpen(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to mplExtension.LuaBehaviour.MplOnOpen!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MplOnOpenEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MplOnOpenEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MplOnCloseEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MplOnCloseEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MplOnClose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        object gen_ret = gen_to_be_invoked.MplOnClose(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MplRefresh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MplRefresh(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetThis(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.MonoBehaviour _mono = (UnityEngine.MonoBehaviour)translator.GetObject(L, 2, typeof(UnityEngine.MonoBehaviour));
                    
                    gen_to_be_invoked.SetThis( _mono );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _data = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.SetData( _data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Awake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Awake(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Start(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Start(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDestroy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnDestroy(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MplUpdateSelectedView(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                mplExtension.LuaBehaviour gen_to_be_invoked = (mplExtension.LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isSelected = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.MplUpdateSelectedView( _isSelected );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}

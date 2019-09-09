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
    public class UnityEngineAndroidJavaProxyWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AndroidJavaProxy);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Invoke", _m_Invoke);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "equals", _m_equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "hashCode", _m_hashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "toString", _m_toString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "javaInterface", _g_get_javaInterface);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _javaInterface = LuaAPI.lua_tostring(L, 2);
					
					UnityEngine.AndroidJavaProxy gen_ret = new UnityEngine.AndroidJavaProxy(_javaInterface);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.AndroidJavaClass>(L, 2))
				{
					UnityEngine.AndroidJavaClass _javaInterface = (UnityEngine.AndroidJavaClass)translator.GetObject(L, 2, typeof(UnityEngine.AndroidJavaClass));
					
					UnityEngine.AndroidJavaProxy gen_ret = new UnityEngine.AndroidJavaProxy(_javaInterface);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AndroidJavaProxy constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Invoke(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AndroidJavaProxy gen_to_be_invoked = (UnityEngine.AndroidJavaProxy)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object[]>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object[] _args = (object[])translator.GetObject(L, 3, typeof(object[]));
                    
                        UnityEngine.AndroidJavaObject gen_ret = gen_to_be_invoked.Invoke( _methodName, _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.AndroidJavaObject[]>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.AndroidJavaObject[] _javaArgs = (UnityEngine.AndroidJavaObject[])translator.GetObject(L, 3, typeof(UnityEngine.AndroidJavaObject[]));
                    
                        UnityEngine.AndroidJavaObject gen_ret = gen_to_be_invoked.Invoke( _methodName, _javaArgs );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AndroidJavaProxy.Invoke!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AndroidJavaProxy gen_to_be_invoked = (UnityEngine.AndroidJavaProxy)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AndroidJavaObject _obj = (UnityEngine.AndroidJavaObject)translator.GetObject(L, 2, typeof(UnityEngine.AndroidJavaObject));
                    
                        bool gen_ret = gen_to_be_invoked.equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_hashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AndroidJavaProxy gen_to_be_invoked = (UnityEngine.AndroidJavaProxy)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.hashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_toString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AndroidJavaProxy gen_to_be_invoked = (UnityEngine.AndroidJavaProxy)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.toString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_javaInterface(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AndroidJavaProxy gen_to_be_invoked = (UnityEngine.AndroidJavaProxy)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.javaInterface);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

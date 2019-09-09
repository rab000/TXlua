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
    public class UnityEngineAndroidJNIHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AndroidJNIHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetConstructorID", _m_GetConstructorID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMethodID", _m_GetMethodID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFieldID", _m_GetFieldID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateJavaRunnable", _m_CreateJavaRunnable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateJavaProxy", _m_CreateJavaProxy_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ConvertToJNIArray", _m_ConvertToJNIArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateJNIArgArray", _m_CreateJNIArgArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeleteJNIArgArray", _m_DeleteJNIArgArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSignature", _m_GetSignature_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "debug", _g_get_debug);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "debug", _s_set_debug);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.AndroidJNIHelper does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConstructorID_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetConstructorID( _javaClass );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    string _signature = LuaAPI.lua_tostring(L, 2);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetConstructorID( _javaClass, _signature );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& translator.Assignable<object[]>(L, 2)) 
                {
                    System.IntPtr _jclass = LuaAPI.lua_touserdata(L, 1);
                    object[] _args = (object[])translator.GetObject(L, 2, typeof(object[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetConstructorID( _jclass, _args );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AndroidJNIHelper.GetConstructorID!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMethodID_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetMethodID( _javaClass, _methodName );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    string _signature = LuaAPI.lua_tostring(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetMethodID( _javaClass, _methodName, _signature );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    string _signature = LuaAPI.lua_tostring(L, 3);
                    bool _isStatic = LuaAPI.lua_toboolean(L, 4);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetMethodID( _javaClass, _methodName, _signature, _isStatic );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object[]>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    System.IntPtr _jclass = LuaAPI.lua_touserdata(L, 1);
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object[] _args = (object[])translator.GetObject(L, 3, typeof(object[]));
                    bool _isStatic = LuaAPI.lua_toboolean(L, 4);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetMethodID( _jclass, _methodName, _args, _isStatic );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AndroidJNIHelper.GetMethodID!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFieldID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    string _fieldName = LuaAPI.lua_tostring(L, 2);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetFieldID( _javaClass, _fieldName );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    string _fieldName = LuaAPI.lua_tostring(L, 2);
                    string _signature = LuaAPI.lua_tostring(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetFieldID( _javaClass, _fieldName, _signature );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    System.IntPtr _javaClass = LuaAPI.lua_touserdata(L, 1);
                    string _fieldName = LuaAPI.lua_tostring(L, 2);
                    string _signature = LuaAPI.lua_tostring(L, 3);
                    bool _isStatic = LuaAPI.lua_toboolean(L, 4);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.GetFieldID( _javaClass, _fieldName, _signature, _isStatic );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AndroidJNIHelper.GetFieldID!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateJavaRunnable_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.AndroidJavaRunnable _jrunnable = translator.GetDelegate<UnityEngine.AndroidJavaRunnable>(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.CreateJavaRunnable( _jrunnable );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateJavaProxy_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.AndroidJavaProxy _proxy = (UnityEngine.AndroidJavaProxy)translator.GetObject(L, 1, typeof(UnityEngine.AndroidJavaProxy));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.CreateJavaProxy( _proxy );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConvertToJNIArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNIHelper.ConvertToJNIArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateJNIArgArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object[] _args = (object[])translator.GetObject(L, 1, typeof(object[]));
                    
                        UnityEngine.jvalue[] gen_ret = UnityEngine.AndroidJNIHelper.CreateJNIArgArray( _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteJNIArgArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object[] _args = (object[])translator.GetObject(L, 1, typeof(object[]));
                    UnityEngine.jvalue[] _jniArgs = (UnityEngine.jvalue[])translator.GetObject(L, 2, typeof(UnityEngine.jvalue[]));
                    
                    UnityEngine.AndroidJNIHelper.DeleteJNIArgArray( _args, _jniArgs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSignature_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object _obj = translator.GetObject(L, 1, typeof(object));
                    
                        string gen_ret = UnityEngine.AndroidJNIHelper.GetSignature( _obj );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<object[]>(L, 1)) 
                {
                    object[] _args = (object[])translator.GetObject(L, 1, typeof(object[]));
                    
                        string gen_ret = UnityEngine.AndroidJNIHelper.GetSignature( _args );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AndroidJNIHelper.GetSignature!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_debug(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.AndroidJNIHelper.debug);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_debug(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.AndroidJNIHelper.debug = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

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
    public class UnityEngineAndroidJNIWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AndroidJNI);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 144, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AttachCurrentThread", _m_AttachCurrentThread_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DetachCurrentThread", _m_DetachCurrentThread_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetVersion", _m_GetVersion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindClass", _m_FindClass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromReflectedMethod", _m_FromReflectedMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromReflectedField", _m_FromReflectedField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToReflectedMethod", _m_ToReflectedMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToReflectedField", _m_ToReflectedField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSuperclass", _m_GetSuperclass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsAssignableFrom", _m_IsAssignableFrom_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Throw", _m_Throw_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ThrowNew", _m_ThrowNew_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExceptionOccurred", _m_ExceptionOccurred_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExceptionDescribe", _m_ExceptionDescribe_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExceptionClear", _m_ExceptionClear_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FatalError", _m_FatalError_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PushLocalFrame", _m_PushLocalFrame_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PopLocalFrame", _m_PopLocalFrame_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewGlobalRef", _m_NewGlobalRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeleteGlobalRef", _m_DeleteGlobalRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewLocalRef", _m_NewLocalRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DeleteLocalRef", _m_DeleteLocalRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsSameObject", _m_IsSameObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EnsureLocalCapacity", _m_EnsureLocalCapacity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AllocObject", _m_AllocObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewObject", _m_NewObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetObjectClass", _m_GetObjectClass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsInstanceOf", _m_IsInstanceOf_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMethodID", _m_GetMethodID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFieldID", _m_GetFieldID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticMethodID", _m_GetStaticMethodID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticFieldID", _m_GetStaticFieldID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewStringUTF", _m_NewStringUTF_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStringUTFLength", _m_GetStringUTFLength_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStringUTFChars", _m_GetStringUTFChars_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStringMethod", _m_CallStringMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallObjectMethod", _m_CallObjectMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallIntMethod", _m_CallIntMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallBooleanMethod", _m_CallBooleanMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallShortMethod", _m_CallShortMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallByteMethod", _m_CallByteMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallCharMethod", _m_CallCharMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallFloatMethod", _m_CallFloatMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallDoubleMethod", _m_CallDoubleMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallLongMethod", _m_CallLongMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallVoidMethod", _m_CallVoidMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStringField", _m_GetStringField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetObjectField", _m_GetObjectField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBooleanField", _m_GetBooleanField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetByteField", _m_GetByteField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCharField", _m_GetCharField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetShortField", _m_GetShortField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIntField", _m_GetIntField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLongField", _m_GetLongField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFloatField", _m_GetFloatField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDoubleField", _m_GetDoubleField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStringField", _m_SetStringField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetObjectField", _m_SetObjectField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetBooleanField", _m_SetBooleanField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetByteField", _m_SetByteField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCharField", _m_SetCharField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetShortField", _m_SetShortField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetIntField", _m_SetIntField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLongField", _m_SetLongField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetFloatField", _m_SetFloatField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetDoubleField", _m_SetDoubleField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticStringMethod", _m_CallStaticStringMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticObjectMethod", _m_CallStaticObjectMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticIntMethod", _m_CallStaticIntMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticBooleanMethod", _m_CallStaticBooleanMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticShortMethod", _m_CallStaticShortMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticByteMethod", _m_CallStaticByteMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticCharMethod", _m_CallStaticCharMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticFloatMethod", _m_CallStaticFloatMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticDoubleMethod", _m_CallStaticDoubleMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticLongMethod", _m_CallStaticLongMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CallStaticVoidMethod", _m_CallStaticVoidMethod_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticStringField", _m_GetStaticStringField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticObjectField", _m_GetStaticObjectField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticBooleanField", _m_GetStaticBooleanField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticByteField", _m_GetStaticByteField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticCharField", _m_GetStaticCharField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticShortField", _m_GetStaticShortField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticIntField", _m_GetStaticIntField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticLongField", _m_GetStaticLongField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticFloatField", _m_GetStaticFloatField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStaticDoubleField", _m_GetStaticDoubleField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticStringField", _m_SetStaticStringField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticObjectField", _m_SetStaticObjectField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticBooleanField", _m_SetStaticBooleanField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticByteField", _m_SetStaticByteField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticCharField", _m_SetStaticCharField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticShortField", _m_SetStaticShortField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticIntField", _m_SetStaticIntField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticLongField", _m_SetStaticLongField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticFloatField", _m_SetStaticFloatField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStaticDoubleField", _m_SetStaticDoubleField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToBooleanArray", _m_ToBooleanArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToByteArray", _m_ToByteArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToCharArray", _m_ToCharArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToShortArray", _m_ToShortArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToIntArray", _m_ToIntArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToLongArray", _m_ToLongArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToFloatArray", _m_ToFloatArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToDoubleArray", _m_ToDoubleArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToObjectArray", _m_ToObjectArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromBooleanArray", _m_FromBooleanArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromByteArray", _m_FromByteArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromCharArray", _m_FromCharArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromShortArray", _m_FromShortArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromIntArray", _m_FromIntArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromLongArray", _m_FromLongArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromFloatArray", _m_FromFloatArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromDoubleArray", _m_FromDoubleArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromObjectArray", _m_FromObjectArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetArrayLength", _m_GetArrayLength_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewBooleanArray", _m_NewBooleanArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewByteArray", _m_NewByteArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewCharArray", _m_NewCharArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewShortArray", _m_NewShortArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewIntArray", _m_NewIntArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewLongArray", _m_NewLongArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewFloatArray", _m_NewFloatArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewDoubleArray", _m_NewDoubleArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewObjectArray", _m_NewObjectArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBooleanArrayElement", _m_GetBooleanArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetByteArrayElement", _m_GetByteArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCharArrayElement", _m_GetCharArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetShortArrayElement", _m_GetShortArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIntArrayElement", _m_GetIntArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLongArrayElement", _m_GetLongArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFloatArrayElement", _m_GetFloatArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDoubleArrayElement", _m_GetDoubleArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetObjectArrayElement", _m_GetObjectArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetBooleanArrayElement", _m_SetBooleanArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetByteArrayElement", _m_SetByteArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCharArrayElement", _m_SetCharArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetShortArrayElement", _m_SetShortArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetIntArrayElement", _m_SetIntArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLongArrayElement", _m_SetLongArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetFloatArrayElement", _m_SetFloatArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetDoubleArrayElement", _m_SetDoubleArrayElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetObjectArrayElement", _m_SetObjectArrayElement_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.AndroidJNI does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttachCurrentThread_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = UnityEngine.AndroidJNI.AttachCurrentThread(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DetachCurrentThread_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = UnityEngine.AndroidJNI.DetachCurrentThread(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVersion_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = UnityEngine.AndroidJNI.GetVersion(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindClass_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.FindClass( _name );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromReflectedMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _refMethod = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.FromReflectedMethod( _refMethod );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromReflectedField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _refField = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.FromReflectedField( _refField );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToReflectedMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    bool _isStatic = LuaAPI.lua_toboolean(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToReflectedMethod( _clazz, _methodID, _isStatic );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToReflectedField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    bool _isStatic = LuaAPI.lua_toboolean(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToReflectedField( _clazz, _fieldID, _isStatic );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSuperclass_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetSuperclass( _clazz );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssignableFrom_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz1 = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _clazz2 = LuaAPI.lua_touserdata(L, 2);
                    
                        bool gen_ret = UnityEngine.AndroidJNI.IsAssignableFrom( _clazz1, _clazz2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Throw_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = UnityEngine.AndroidJNI.Throw( _obj );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ThrowNew_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    string _message = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = UnityEngine.AndroidJNI.ThrowNew( _clazz, _message );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExceptionOccurred_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ExceptionOccurred(  );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExceptionDescribe_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.AndroidJNI.ExceptionDescribe(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExceptionClear_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.AndroidJNI.ExceptionClear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FatalError_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _message = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.AndroidJNI.FatalError( _message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushLocalFrame_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _capacity = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = UnityEngine.AndroidJNI.PushLocalFrame( _capacity );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PopLocalFrame_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _ptr = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.PopLocalFrame( _ptr );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewGlobalRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewGlobalRef( _obj );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteGlobalRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    
                    UnityEngine.AndroidJNI.DeleteGlobalRef( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewLocalRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewLocalRef( _obj );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteLocalRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    
                    UnityEngine.AndroidJNI.DeleteLocalRef( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSameObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj1 = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _obj2 = LuaAPI.lua_touserdata(L, 2);
                    
                        bool gen_ret = UnityEngine.AndroidJNI.IsSameObject( _obj1, _obj2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnsureLocalCapacity_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _capacity = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = UnityEngine.AndroidJNI.EnsureLocalCapacity( _capacity );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AllocObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.AllocObject( _clazz );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewObject( _clazz, _methodID, _args );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectClass_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetObjectClass( _obj );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsInstanceOf_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 2);
                    
                        bool gen_ret = UnityEngine.AndroidJNI.IsInstanceOf( _obj, _clazz );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMethodID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _sig = LuaAPI.lua_tostring(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetMethodID( _clazz, _name, _sig );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFieldID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _sig = LuaAPI.lua_tostring(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetFieldID( _clazz, _name, _sig );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticMethodID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _sig = LuaAPI.lua_tostring(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetStaticMethodID( _clazz, _name, _sig );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticFieldID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _sig = LuaAPI.lua_tostring(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetStaticFieldID( _clazz, _name, _sig );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewStringUTF_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _bytes = LuaAPI.lua_tostring(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewStringUTF( _bytes );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStringUTFLength_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _str = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = UnityEngine.AndroidJNI.GetStringUTFLength( _str );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStringUTFChars_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _str = LuaAPI.lua_touserdata(L, 1);
                    
                        string gen_ret = UnityEngine.AndroidJNI.GetStringUTFChars( _str );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStringMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        string gen_ret = UnityEngine.AndroidJNI.CallStringMethod( _obj, _methodID, _args );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallObjectMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.CallObjectMethod( _obj, _methodID, _args );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallIntMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        int gen_ret = UnityEngine.AndroidJNI.CallIntMethod( _obj, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallBooleanMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        bool gen_ret = UnityEngine.AndroidJNI.CallBooleanMethod( _obj, _methodID, _args );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallShortMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        short gen_ret = UnityEngine.AndroidJNI.CallShortMethod( _obj, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallByteMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        byte gen_ret = UnityEngine.AndroidJNI.CallByteMethod( _obj, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallCharMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        char gen_ret = UnityEngine.AndroidJNI.CallCharMethod( _obj, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallFloatMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        float gen_ret = UnityEngine.AndroidJNI.CallFloatMethod( _obj, _methodID, _args );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallDoubleMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        double gen_ret = UnityEngine.AndroidJNI.CallDoubleMethod( _obj, _methodID, _args );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallLongMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        long gen_ret = UnityEngine.AndroidJNI.CallLongMethod( _obj, _methodID, _args );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallVoidMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                    UnityEngine.AndroidJNI.CallVoidMethod( _obj, _methodID, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStringField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        string gen_ret = UnityEngine.AndroidJNI.GetStringField( _obj, _fieldID );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetObjectField( _obj, _fieldID );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBooleanField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        bool gen_ret = UnityEngine.AndroidJNI.GetBooleanField( _obj, _fieldID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetByteField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        byte gen_ret = UnityEngine.AndroidJNI.GetByteField( _obj, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCharField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        char gen_ret = UnityEngine.AndroidJNI.GetCharField( _obj, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetShortField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        short gen_ret = UnityEngine.AndroidJNI.GetShortField( _obj, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIntField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        int gen_ret = UnityEngine.AndroidJNI.GetIntField( _obj, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLongField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        long gen_ret = UnityEngine.AndroidJNI.GetLongField( _obj, _fieldID );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloatField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        float gen_ret = UnityEngine.AndroidJNI.GetFloatField( _obj, _fieldID );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDoubleField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        double gen_ret = UnityEngine.AndroidJNI.GetDoubleField( _obj, _fieldID );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStringField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    string _val = LuaAPI.lua_tostring(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStringField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetObjectField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    System.IntPtr _val = LuaAPI.lua_touserdata(L, 3);
                    
                    UnityEngine.AndroidJNI.SetObjectField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBooleanField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    bool _val = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.AndroidJNI.SetBooleanField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetByteField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    byte _val = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetByteField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCharField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    char _val = (char)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetCharField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetShortField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    short _val = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetShortField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIntField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    int _val = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetIntField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLongField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    long _val = LuaAPI.lua_toint64(L, 3);
                    
                    UnityEngine.AndroidJNI.SetLongField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloatField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    float _val = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.AndroidJNI.SetFloatField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDoubleField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    double _val = LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.AndroidJNI.SetDoubleField( _obj, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticStringMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        string gen_ret = UnityEngine.AndroidJNI.CallStaticStringMethod( _clazz, _methodID, _args );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticObjectMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.CallStaticObjectMethod( _clazz, _methodID, _args );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticIntMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        int gen_ret = UnityEngine.AndroidJNI.CallStaticIntMethod( _clazz, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticBooleanMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        bool gen_ret = UnityEngine.AndroidJNI.CallStaticBooleanMethod( _clazz, _methodID, _args );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticShortMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        short gen_ret = UnityEngine.AndroidJNI.CallStaticShortMethod( _clazz, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticByteMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        byte gen_ret = UnityEngine.AndroidJNI.CallStaticByteMethod( _clazz, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticCharMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        char gen_ret = UnityEngine.AndroidJNI.CallStaticCharMethod( _clazz, _methodID, _args );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticFloatMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        float gen_ret = UnityEngine.AndroidJNI.CallStaticFloatMethod( _clazz, _methodID, _args );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticDoubleMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        double gen_ret = UnityEngine.AndroidJNI.CallStaticDoubleMethod( _clazz, _methodID, _args );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticLongMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                        long gen_ret = UnityEngine.AndroidJNI.CallStaticLongMethod( _clazz, _methodID, _args );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallStaticVoidMethod_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _methodID = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.jvalue[] _args = (UnityEngine.jvalue[])translator.GetObject(L, 3, typeof(UnityEngine.jvalue[]));
                    
                    UnityEngine.AndroidJNI.CallStaticVoidMethod( _clazz, _methodID, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticStringField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        string gen_ret = UnityEngine.AndroidJNI.GetStaticStringField( _clazz, _fieldID );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticObjectField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetStaticObjectField( _clazz, _fieldID );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticBooleanField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        bool gen_ret = UnityEngine.AndroidJNI.GetStaticBooleanField( _clazz, _fieldID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticByteField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        byte gen_ret = UnityEngine.AndroidJNI.GetStaticByteField( _clazz, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticCharField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        char gen_ret = UnityEngine.AndroidJNI.GetStaticCharField( _clazz, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticShortField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        short gen_ret = UnityEngine.AndroidJNI.GetStaticShortField( _clazz, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticIntField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        int gen_ret = UnityEngine.AndroidJNI.GetStaticIntField( _clazz, _fieldID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticLongField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        long gen_ret = UnityEngine.AndroidJNI.GetStaticLongField( _clazz, _fieldID );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticFloatField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        float gen_ret = UnityEngine.AndroidJNI.GetStaticFloatField( _clazz, _fieldID );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStaticDoubleField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    
                        double gen_ret = UnityEngine.AndroidJNI.GetStaticDoubleField( _clazz, _fieldID );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticStringField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    string _val = LuaAPI.lua_tostring(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticStringField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticObjectField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    System.IntPtr _val = LuaAPI.lua_touserdata(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticObjectField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticBooleanField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    bool _val = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticBooleanField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticByteField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    byte _val = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticByteField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticCharField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    char _val = (char)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticCharField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticShortField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    short _val = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticShortField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticIntField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    int _val = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticIntField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticLongField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    long _val = LuaAPI.lua_toint64(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticLongField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticFloatField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    float _val = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticFloatField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStaticDoubleField_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fieldID = LuaAPI.lua_touserdata(L, 2);
                    double _val = LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.AndroidJNI.SetStaticDoubleField( _clazz, _fieldID, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToBooleanArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    bool[] _array = (bool[])translator.GetObject(L, 1, typeof(bool[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToBooleanArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToByteArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _array = LuaAPI.lua_tobytes(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToByteArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToCharArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    char[] _array = (char[])translator.GetObject(L, 1, typeof(char[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToCharArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToShortArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    short[] _array = (short[])translator.GetObject(L, 1, typeof(short[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToShortArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToIntArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int[] _array = (int[])translator.GetObject(L, 1, typeof(int[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToIntArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToLongArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    long[] _array = (long[])translator.GetObject(L, 1, typeof(long[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToLongArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToFloatArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float[] _array = (float[])translator.GetObject(L, 1, typeof(float[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToFloatArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToDoubleArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    double[] _array = (double[])translator.GetObject(L, 1, typeof(double[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToDoubleArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToObjectArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<System.IntPtr[]>(L, 1)) 
                {
                    System.IntPtr[] _array = (System.IntPtr[])translator.GetObject(L, 1, typeof(System.IntPtr[]));
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToObjectArray( _array );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.IntPtr[]>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr[] _array = (System.IntPtr[])translator.GetObject(L, 1, typeof(System.IntPtr[]));
                    System.IntPtr _arrayClass = LuaAPI.lua_touserdata(L, 2);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.ToObjectArray( _array, _arrayClass );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AndroidJNI.ToObjectArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromBooleanArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        bool[] gen_ret = UnityEngine.AndroidJNI.FromBooleanArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromByteArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        byte[] gen_ret = UnityEngine.AndroidJNI.FromByteArray( _array );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromCharArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        char[] gen_ret = UnityEngine.AndroidJNI.FromCharArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromShortArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        short[] gen_ret = UnityEngine.AndroidJNI.FromShortArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromIntArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        int[] gen_ret = UnityEngine.AndroidJNI.FromIntArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromLongArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        long[] gen_ret = UnityEngine.AndroidJNI.FromLongArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromFloatArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        float[] gen_ret = UnityEngine.AndroidJNI.FromFloatArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromDoubleArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        double[] gen_ret = UnityEngine.AndroidJNI.FromDoubleArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromObjectArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr[] gen_ret = UnityEngine.AndroidJNI.FromObjectArray( _array );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetArrayLength_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = UnityEngine.AndroidJNI.GetArrayLength( _array );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewBooleanArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewBooleanArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewByteArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewByteArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewCharArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewCharArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewShortArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewShortArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewIntArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewIntArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewLongArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewLongArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewFloatArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewFloatArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewDoubleArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewDoubleArray( _size );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewObjectArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 1);
                    System.IntPtr _clazz = LuaAPI.lua_touserdata(L, 2);
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 3);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.NewObjectArray( _size, _clazz, _obj );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBooleanArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = UnityEngine.AndroidJNI.GetBooleanArrayElement( _array, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetByteArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        byte gen_ret = UnityEngine.AndroidJNI.GetByteArrayElement( _array, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCharArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        char gen_ret = UnityEngine.AndroidJNI.GetCharArrayElement( _array, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetShortArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        short gen_ret = UnityEngine.AndroidJNI.GetShortArrayElement( _array, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIntArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = UnityEngine.AndroidJNI.GetIntArrayElement( _array, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLongArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        long gen_ret = UnityEngine.AndroidJNI.GetLongArrayElement( _array, _index );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloatArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        float gen_ret = UnityEngine.AndroidJNI.GetFloatArrayElement( _array, _index );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDoubleArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        double gen_ret = UnityEngine.AndroidJNI.GetDoubleArrayElement( _array, _index );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.IntPtr gen_ret = UnityEngine.AndroidJNI.GetObjectArrayElement( _array, _index );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBooleanArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    byte _val = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetBooleanArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetByteArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    sbyte _val = (sbyte)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetByteArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCharArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    char _val = (char)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetCharArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetShortArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    short _val = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetShortArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIntArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    int _val = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.AndroidJNI.SetIntArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLongArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    long _val = LuaAPI.lua_toint64(L, 3);
                    
                    UnityEngine.AndroidJNI.SetLongArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloatArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    float _val = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.AndroidJNI.SetFloatArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDoubleArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    double _val = LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.AndroidJNI.SetDoubleArrayElement( _array, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetObjectArrayElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _array = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    System.IntPtr _obj = LuaAPI.lua_touserdata(L, 3);
                    
                    UnityEngine.AndroidJNI.SetObjectArrayElement( _array, _index, _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}

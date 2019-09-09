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
    public class UnityEngineDetailPrototypeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.DetailPrototype);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 12, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "prototype", _g_get_prototype);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "prototypeTexture", _g_get_prototypeTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", _g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxWidth", _g_get_maxWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", _g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxHeight", _g_get_maxHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "noiseSpread", _g_get_noiseSpread);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bendFactor", _g_get_bendFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "healthyColor", _g_get_healthyColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dryColor", _g_get_dryColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderMode", _g_get_renderMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "usePrototypeMesh", _g_get_usePrototypeMesh);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "prototype", _s_set_prototype);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "prototypeTexture", _s_set_prototypeTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minWidth", _s_set_minWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxWidth", _s_set_maxWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minHeight", _s_set_minHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxHeight", _s_set_maxHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "noiseSpread", _s_set_noiseSpread);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bendFactor", _s_set_bendFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "healthyColor", _s_set_healthyColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dryColor", _s_set_dryColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderMode", _s_set_renderMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "usePrototypeMesh", _s_set_usePrototypeMesh);
            
			
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
					
					UnityEngine.DetailPrototype gen_ret = new UnityEngine.DetailPrototype();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.DetailPrototype>(L, 2))
				{
					UnityEngine.DetailPrototype _other = (UnityEngine.DetailPrototype)translator.GetObject(L, 2, typeof(UnityEngine.DetailPrototype));
					
					UnityEngine.DetailPrototype gen_ret = new UnityEngine.DetailPrototype(_other);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.DetailPrototype constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_prototype(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.prototype);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_prototypeTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.prototypeTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_noiseSpread(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.noiseSpread);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bendFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.bendFactor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_healthyColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.healthyColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dryColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.dryColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.renderMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usePrototypeMesh(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.usePrototypeMesh);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_prototype(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.prototype = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_prototypeTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.prototypeTexture = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_noiseSpread(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.noiseSpread = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bendFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bendFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_healthyColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.healthyColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dryColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.dryColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                UnityEngine.DetailRenderMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.renderMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_usePrototypeMesh(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.DetailPrototype gen_to_be_invoked = (UnityEngine.DetailPrototype)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.usePrototypeMesh = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

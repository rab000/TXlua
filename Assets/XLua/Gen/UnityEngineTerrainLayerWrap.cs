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
    public class UnityEngineTerrainLayerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.TerrainLayer);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 13, 13);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "diffuseTexture", _g_get_diffuseTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalMapTexture", _g_get_normalMapTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maskMapTexture", _g_get_maskMapTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tileSize", _g_get_tileSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tileOffset", _g_get_tileOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "specular", _g_get_specular);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "metallic", _g_get_metallic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothness", _g_get_smoothness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalScale", _g_get_normalScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "diffuseRemapMin", _g_get_diffuseRemapMin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "diffuseRemapMax", _g_get_diffuseRemapMax);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maskMapRemapMin", _g_get_maskMapRemapMin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maskMapRemapMax", _g_get_maskMapRemapMax);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "diffuseTexture", _s_set_diffuseTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normalMapTexture", _s_set_normalMapTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maskMapTexture", _s_set_maskMapTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tileSize", _s_set_tileSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tileOffset", _s_set_tileOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "specular", _s_set_specular);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "metallic", _s_set_metallic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothness", _s_set_smoothness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normalScale", _s_set_normalScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "diffuseRemapMin", _s_set_diffuseRemapMin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "diffuseRemapMax", _s_set_diffuseRemapMax);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maskMapRemapMin", _s_set_maskMapRemapMin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maskMapRemapMax", _s_set_maskMapRemapMax);
            
			
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
					
					UnityEngine.TerrainLayer gen_ret = new UnityEngine.TerrainLayer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.TerrainLayer constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_diffuseTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.diffuseTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normalMapTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.normalMapTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maskMapTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.maskMapTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tileSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.tileSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tileOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.tileOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_specular(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.specular);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_metallic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.metallic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.smoothness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normalScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.normalScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_diffuseRemapMin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, gen_to_be_invoked.diffuseRemapMin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_diffuseRemapMax(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, gen_to_be_invoked.diffuseRemapMax);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maskMapRemapMin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, gen_to_be_invoked.maskMapRemapMin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maskMapRemapMax(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, gen_to_be_invoked.maskMapRemapMax);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_diffuseTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.diffuseTexture = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_normalMapTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.normalMapTexture = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maskMapTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maskMapTexture = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tileSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.tileSize = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tileOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.tileOffset = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_specular(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.specular = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_metallic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.metallic = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_normalScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.normalScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_diffuseRemapMin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.diffuseRemapMin = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_diffuseRemapMax(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.diffuseRemapMax = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maskMapRemapMin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.maskMapRemapMin = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maskMapRemapMax(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainLayer gen_to_be_invoked = (UnityEngine.TerrainLayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.maskMapRemapMax = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

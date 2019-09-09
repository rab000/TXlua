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
    public class UnityEngineCustomGridBrushAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.CustomGridBrushAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 0);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideAssetInstances", _g_get_hideAssetInstances);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideDefaultInstance", _g_get_hideDefaultInstance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultBrush", _g_get_defaultBrush);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultName", _g_get_defaultName);
            
			
			
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
					
					UnityEngine.CustomGridBrushAttribute gen_ret = new UnityEngine.CustomGridBrushAttribute();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING))
				{
					bool _hideAssetInstances = LuaAPI.lua_toboolean(L, 2);
					bool _hideDefaultInstance = LuaAPI.lua_toboolean(L, 3);
					bool _defaultBrush = LuaAPI.lua_toboolean(L, 4);
					string _defaultName = LuaAPI.lua_tostring(L, 5);
					
					UnityEngine.CustomGridBrushAttribute gen_ret = new UnityEngine.CustomGridBrushAttribute(_hideAssetInstances, _hideDefaultInstance, _defaultBrush, _defaultName);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CustomGridBrushAttribute constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hideAssetInstances(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomGridBrushAttribute gen_to_be_invoked = (UnityEngine.CustomGridBrushAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hideAssetInstances);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hideDefaultInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomGridBrushAttribute gen_to_be_invoked = (UnityEngine.CustomGridBrushAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hideDefaultInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultBrush(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomGridBrushAttribute gen_to_be_invoked = (UnityEngine.CustomGridBrushAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.defaultBrush);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomGridBrushAttribute gen_to_be_invoked = (UnityEngine.CustomGridBrushAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.defaultName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

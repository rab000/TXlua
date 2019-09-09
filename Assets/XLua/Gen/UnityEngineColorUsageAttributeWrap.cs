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
    public class UnityEngineColorUsageAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ColorUsageAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 2, 0);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "showAlpha", _g_get_showAlpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hdr", _g_get_hdr);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2))
				{
					bool _showAlpha = LuaAPI.lua_toboolean(L, 2);
					
					UnityEngine.ColorUsageAttribute gen_ret = new UnityEngine.ColorUsageAttribute(_showAlpha);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					bool _showAlpha = LuaAPI.lua_toboolean(L, 2);
					bool _hdr = LuaAPI.lua_toboolean(L, 3);
					
					UnityEngine.ColorUsageAttribute gen_ret = new UnityEngine.ColorUsageAttribute(_showAlpha, _hdr);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ColorUsageAttribute constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showAlpha(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ColorUsageAttribute gen_to_be_invoked = (UnityEngine.ColorUsageAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.showAlpha);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hdr(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ColorUsageAttribute gen_to_be_invoked = (UnityEngine.ColorUsageAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hdr);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

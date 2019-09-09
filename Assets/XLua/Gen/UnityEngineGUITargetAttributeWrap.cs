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
    public class UnityEngineGUITargetAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GUITargetAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
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
					
					UnityEngine.GUITargetAttribute gen_ret = new UnityEngine.GUITargetAttribute();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _displayIndex = LuaAPI.xlua_tointeger(L, 2);
					
					UnityEngine.GUITargetAttribute gen_ret = new UnityEngine.GUITargetAttribute(_displayIndex);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					int _displayIndex = LuaAPI.xlua_tointeger(L, 2);
					int _displayIndex1 = LuaAPI.xlua_tointeger(L, 3);
					
					UnityEngine.GUITargetAttribute gen_ret = new UnityEngine.GUITargetAttribute(_displayIndex, _displayIndex1);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)))
				{
					int _displayIndex = LuaAPI.xlua_tointeger(L, 2);
					int _displayIndex1 = LuaAPI.xlua_tointeger(L, 3);
					int[] _displayIndexList = translator.GetParams<int>(L, 4);
					
					UnityEngine.GUITargetAttribute gen_ret = new UnityEngine.GUITargetAttribute(_displayIndex, _displayIndex1, _displayIndexList);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUITargetAttribute constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}

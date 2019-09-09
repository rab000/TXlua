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
    public class UnityEngineGUIGroupScopeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GUI.GroupScope);
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
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Rect>(L, 2))
				{
					UnityEngine.Rect _position;translator.Get(L, 2, out _position);
					
					UnityEngine.GUI.GroupScope gen_ret = new UnityEngine.GUI.GroupScope(_position);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					UnityEngine.Rect _position;translator.Get(L, 2, out _position);
					string _text = LuaAPI.lua_tostring(L, 3);
					
					UnityEngine.GUI.GroupScope gen_ret = new UnityEngine.GUI.GroupScope(_position, _text);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Texture>(L, 3))
				{
					UnityEngine.Rect _position;translator.Get(L, 2, out _position);
					UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
					
					UnityEngine.GUI.GroupScope gen_ret = new UnityEngine.GUI.GroupScope(_position, _image);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.GUIContent>(L, 3))
				{
					UnityEngine.Rect _position;translator.Get(L, 2, out _position);
					UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
					
					UnityEngine.GUI.GroupScope gen_ret = new UnityEngine.GUI.GroupScope(_position, _content);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3))
				{
					UnityEngine.Rect _position;translator.Get(L, 2, out _position);
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.GroupScope gen_ret = new UnityEngine.GUI.GroupScope(_position, _style);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.GUIStyle>(L, 4))
				{
					UnityEngine.Rect _position;translator.Get(L, 2, out _position);
					string _text = LuaAPI.lua_tostring(L, 3);
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.GroupScope gen_ret = new UnityEngine.GUI.GroupScope(_position, _text, _style);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Texture>(L, 3) && translator.Assignable<UnityEngine.GUIStyle>(L, 4))
				{
					UnityEngine.Rect _position;translator.Get(L, 2, out _position);
					UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
					UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.GroupScope gen_ret = new UnityEngine.GUI.GroupScope(_position, _image, _style);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.GroupScope constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}

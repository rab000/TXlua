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
    public class UnityEngineGUILayoutWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GUILayout);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 34, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Label", _m_Label_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Box", _m_Box_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Button", _m_Button_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RepeatButton", _m_RepeatButton_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TextField", _m_TextField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PasswordField", _m_PasswordField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TextArea", _m_TextArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Toggle", _m_Toggle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Toolbar", _m_Toolbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SelectionGrid", _m_SelectionGrid_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HorizontalSlider", _m_HorizontalSlider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VerticalSlider", _m_VerticalSlider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HorizontalScrollbar", _m_HorizontalScrollbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VerticalScrollbar", _m_VerticalScrollbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Space", _m_Space_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FlexibleSpace", _m_FlexibleSpace_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginHorizontal", _m_BeginHorizontal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndHorizontal", _m_EndHorizontal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginVertical", _m_BeginVertical_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndVertical", _m_EndVertical_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginArea", _m_BeginArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndArea", _m_EndArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginScrollView", _m_BeginScrollView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndScrollView", _m_EndScrollView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Window", _m_Window_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Width", _m_Width_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MinWidth", _m_MinWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MaxWidth", _m_MaxWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Height", _m_Height_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MinHeight", _m_MinHeight_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MaxHeight", _m_MaxHeight_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExpandWidth", _m_ExpandWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExpandHeight", _m_ExpandHeight_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUILayout gen_ret = new UnityEngine.GUILayout();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Label_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Label( _image, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Label( _text, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Label( _content, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Label( _image, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Label( _text, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Label( _content, _style, _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Label!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Box_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Box( _image, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Box( _text, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Box( _content, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Box( _image, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Box( _text, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Box( _content, _style, _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Box!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Button_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool gen_ret = UnityEngine.GUILayout.Button( _image, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool gen_ret = UnityEngine.GUILayout.Button( _text, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool gen_ret = UnityEngine.GUILayout.Button( _content, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.Button( _image, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.Button( _text, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.Button( _content, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Button!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatButton_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool gen_ret = UnityEngine.GUILayout.RepeatButton( _image, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool gen_ret = UnityEngine.GUILayout.RepeatButton( _text, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool gen_ret = UnityEngine.GUILayout.RepeatButton( _content, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.RepeatButton( _image, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.RepeatButton( _text, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.RepeatButton( _content, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.RepeatButton!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextField_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        string gen_ret = UnityEngine.GUILayout.TextField( _text, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    int _maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string gen_ret = UnityEngine.GUILayout.TextField( _text, _maxLength, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string gen_ret = UnityEngine.GUILayout.TextField( _text, _style, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    int _maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string gen_ret = UnityEngine.GUILayout.TextField( _text, _maxLength, _style, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.TextField!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PasswordField_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _password = LuaAPI.lua_tostring(L, 1);
                    char _maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string gen_ret = UnityEngine.GUILayout.PasswordField( _password, _maskChar, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string _password = LuaAPI.lua_tostring(L, 1);
                    char _maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    int _maxLength = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string gen_ret = UnityEngine.GUILayout.PasswordField( _password, _maskChar, _maxLength, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string _password = LuaAPI.lua_tostring(L, 1);
                    char _maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string gen_ret = UnityEngine.GUILayout.PasswordField( _password, _maskChar, _style, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    string _password = LuaAPI.lua_tostring(L, 1);
                    char _maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    int _maxLength = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        string gen_ret = UnityEngine.GUILayout.PasswordField( _password, _maskChar, _maxLength, _style, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.PasswordField!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextArea_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        string gen_ret = UnityEngine.GUILayout.TextArea( _text, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    int _maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string gen_ret = UnityEngine.GUILayout.TextArea( _text, _maxLength, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string gen_ret = UnityEngine.GUILayout.TextArea( _text, _style, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    int _maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string gen_ret = UnityEngine.GUILayout.TextArea( _text, _maxLength, _style, _options );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.TextArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toggle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.Toggle( _value, _image, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    string _text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.Toggle( _value, _text, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool gen_ret = UnityEngine.GUILayout.Toggle( _value, _content, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        bool gen_ret = UnityEngine.GUILayout.Toggle( _value, _image, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    string _text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        bool gen_ret = UnityEngine.GUILayout.Toggle( _value, _text, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        bool gen_ret = UnityEngine.GUILayout.Toggle( _value, _content, _style, _options );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Toggle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toolbar_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] _texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _texts, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] _images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _images, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] _contents = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _contents, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] _texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _texts, _style, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] _images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _images, _style, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] _contents = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _contents, _style, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& translator.Assignable<UnityEngine.GUI.ToolbarButtonSize>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] _texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUI.ToolbarButtonSize _buttonSize;translator.Get(L, 4, out _buttonSize);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _texts, _style, _buttonSize, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& translator.Assignable<UnityEngine.GUI.ToolbarButtonSize>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] _images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUI.ToolbarButtonSize _buttonSize;translator.Get(L, 4, out _buttonSize);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _images, _style, _buttonSize, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& translator.Assignable<UnityEngine.GUI.ToolbarButtonSize>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] _contents = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUI.ToolbarButtonSize _buttonSize;translator.Get(L, 4, out _buttonSize);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int gen_ret = UnityEngine.GUILayout.Toolbar( _selected, _contents, _style, _buttonSize, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Toolbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectionGrid_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] _texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    int _xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int gen_ret = UnityEngine.GUILayout.SelectionGrid( _selected, _texts, _xCount, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] _images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    int _xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int gen_ret = UnityEngine.GUILayout.SelectionGrid( _selected, _images, _xCount, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] _content = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    int _xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int gen_ret = UnityEngine.GUILayout.SelectionGrid( _selected, _content, _xCount, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] _texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    int _xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int gen_ret = UnityEngine.GUILayout.SelectionGrid( _selected, _texts, _xCount, _style, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] _images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    int _xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int gen_ret = UnityEngine.GUILayout.SelectionGrid( _selected, _images, _xCount, _style, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] _contents = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    int _xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int gen_ret = UnityEngine.GUILayout.SelectionGrid( _selected, _contents, _xCount, _style, _options );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.SelectionGrid!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HorizontalSlider_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float _rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        float gen_ret = UnityEngine.GUILayout.HorizontalSlider( _value, _leftValue, _rightValue, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float _rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUIStyle _slider = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle _thumb = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float gen_ret = UnityEngine.GUILayout.HorizontalSlider( _value, _leftValue, _rightValue, _slider, _thumb, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.HorizontalSlider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VerticalSlider_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float _rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        float gen_ret = UnityEngine.GUILayout.VerticalSlider( _value, _leftValue, _rightValue, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float _rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUIStyle _slider = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle _thumb = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float gen_ret = UnityEngine.GUILayout.VerticalSlider( _value, _leftValue, _rightValue, _slider, _thumb, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.VerticalSlider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HorizontalScrollbar_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _size = (float)LuaAPI.lua_tonumber(L, 2);
                    float _leftValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float _rightValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        float gen_ret = UnityEngine.GUILayout.HorizontalScrollbar( _value, _size, _leftValue, _rightValue, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _size = (float)LuaAPI.lua_tonumber(L, 2);
                    float _leftValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float _rightValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float gen_ret = UnityEngine.GUILayout.HorizontalScrollbar( _value, _size, _leftValue, _rightValue, _style, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.HorizontalScrollbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VerticalScrollbar_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _size = (float)LuaAPI.lua_tonumber(L, 2);
                    float _topValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float _bottomValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        float gen_ret = UnityEngine.GUILayout.VerticalScrollbar( _value, _size, _topValue, _bottomValue, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    float _size = (float)LuaAPI.lua_tonumber(L, 2);
                    float _topValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float _bottomValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float gen_ret = UnityEngine.GUILayout.VerticalScrollbar( _value, _size, _topValue, _bottomValue, _style, _options );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.VerticalScrollbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Space_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _pixels = (float)LuaAPI.lua_tonumber(L, 1);
                    
                    UnityEngine.GUILayout.Space( _pixels );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FlexibleSpace_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GUILayout.FlexibleSpace(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginHorizontal_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 1))) 
                {
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 1);
                    
                    UnityEngine.GUILayout.BeginHorizontal( _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIStyle>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 1, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.BeginHorizontal( _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginHorizontal( _text, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginHorizontal( _image, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginHorizontal( _content, _style, _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginHorizontal!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndHorizontal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GUILayout.EndHorizontal(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginVertical_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 1))) 
                {
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 1);
                    
                    UnityEngine.GUILayout.BeginVertical( _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIStyle>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 1, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.BeginVertical( _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginVertical( _text, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginVertical( _image, _style, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginVertical( _content, _style, _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginVertical!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndVertical_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GUILayout.EndVertical(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginArea_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Rect>(L, 1)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    string _text = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect, _text );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect, _image );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect, _content );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect, _style );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    string _text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect, _text, _style );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect, _image, _style );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( _screenRect, _content, _style );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndArea_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GUILayout.EndArea(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginScrollView_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 1&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Vector2 _scrollPosition;translator.Get(L, 1, out _scrollPosition);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        UnityEngine.Vector2 gen_ret = UnityEngine.GUILayout.BeginScrollView( _scrollPosition, _options );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    UnityEngine.Vector2 _scrollPosition;translator.Get(L, 1, out _scrollPosition);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Vector2 gen_ret = UnityEngine.GUILayout.BeginScrollView( _scrollPosition, _style );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    UnityEngine.Vector2 _scrollPosition;translator.Get(L, 1, out _scrollPosition);
                    bool _alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 2);
                    bool _alwaysShowVertical = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        UnityEngine.Vector2 gen_ret = UnityEngine.GUILayout.BeginScrollView( _scrollPosition, _alwaysShowHorizontal, _alwaysShowVertical, _options );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Vector2 _scrollPosition;translator.Get(L, 1, out _scrollPosition);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Vector2 gen_ret = UnityEngine.GUILayout.BeginScrollView( _scrollPosition, _style, _options );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    UnityEngine.Vector2 _scrollPosition;translator.Get(L, 1, out _scrollPosition);
                    UnityEngine.GUIStyle _horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle _verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        UnityEngine.Vector2 gen_ret = UnityEngine.GUILayout.BeginScrollView( _scrollPosition, _horizontalScrollbar, _verticalScrollbar, _options );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    UnityEngine.Vector2 _scrollPosition;translator.Get(L, 1, out _scrollPosition);
                    bool _alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 2);
                    bool _alwaysShowVertical = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.GUIStyle _horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle _verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Vector2 gen_ret = UnityEngine.GUILayout.BeginScrollView( _scrollPosition, _alwaysShowHorizontal, _alwaysShowVertical, _horizontalScrollbar, _verticalScrollbar, _options );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& translator.Assignable<UnityEngine.GUIStyle>(L, 6)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 7) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 7))) 
                {
                    UnityEngine.Vector2 _scrollPosition;translator.Get(L, 1, out _scrollPosition);
                    bool _alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 2);
                    bool _alwaysShowVertical = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.GUIStyle _horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle _verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle _background = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 7);
                    
                        UnityEngine.Vector2 gen_ret = UnityEngine.GUILayout.BeginScrollView( _scrollPosition, _alwaysShowHorizontal, _alwaysShowVertical, _horizontalScrollbar, _verticalScrollbar, _background, _options );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginScrollView!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndScrollView_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GUILayout.EndScrollView(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Window_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect _screenRect;translator.Get(L, 2, out _screenRect);
                    UnityEngine.GUI.WindowFunction _func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string _text = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayout.Window( _id, _screenRect, _func, _text, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect _screenRect;translator.Get(L, 2, out _screenRect);
                    UnityEngine.GUI.WindowFunction _func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayout.Window( _id, _screenRect, _func, _image, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect _screenRect;translator.Get(L, 2, out _screenRect);
                    UnityEngine.GUI.WindowFunction _func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayout.Window( _id, _screenRect, _func, _content, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect _screenRect;translator.Get(L, 2, out _screenRect);
                    UnityEngine.GUI.WindowFunction _func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string _text = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayout.Window( _id, _screenRect, _func, _text, _style, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect _screenRect;translator.Get(L, 2, out _screenRect);
                    UnityEngine.GUI.WindowFunction _func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture _image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayout.Window( _id, _screenRect, _func, _image, _style, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect _screenRect;translator.Get(L, 2, out _screenRect);
                    UnityEngine.GUI.WindowFunction _func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent _content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle _style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] _options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect gen_ret = UnityEngine.GUILayout.Window( _id, _screenRect, _func, _content, _style, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Window!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Width_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _width = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.Width( _width );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MinWidth_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.MinWidth( _minWidth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MaxWidth_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _maxWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.MaxWidth( _maxWidth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Height_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _height = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.Height( _height );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MinHeight_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.MinHeight( _minHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MaxHeight_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _maxHeight = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.MaxHeight( _maxHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExpandWidth_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    bool _expand = LuaAPI.lua_toboolean(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.ExpandWidth( _expand );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExpandHeight_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    bool _expand = LuaAPI.lua_toboolean(L, 1);
                    
                        UnityEngine.GUILayoutOption gen_ret = UnityEngine.GUILayout.ExpandHeight( _expand );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}

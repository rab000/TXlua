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
    public class UnityEngineTextGeneratorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.TextGenerator);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 9, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Invalidate", _m_Invalidate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCharacters", _m_GetCharacters);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLines", _m_GetLines);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVertices", _m_GetVertices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPreferredWidth", _m_GetPreferredWidth);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPreferredHeight", _m_GetPreferredHeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PopulateWithErrors", _m_PopulateWithErrors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Populate", _m_Populate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVerticesArray", _m_GetVerticesArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCharactersArray", _m_GetCharactersArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLinesArray", _m_GetLinesArray);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "characterCountVisible", _g_get_characterCountVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verts", _g_get_verts);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "characters", _g_get_characters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lines", _g_get_lines);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rectExtents", _g_get_rectExtents);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertexCount", _g_get_vertexCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "characterCount", _g_get_characterCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineCount", _g_get_lineCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontSizeUsedForBestFit", _g_get_fontSizeUsedForBestFit);
            
			
			
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
					
					UnityEngine.TextGenerator gen_ret = new UnityEngine.TextGenerator();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _initialCapacity = LuaAPI.xlua_tointeger(L, 2);
					
					UnityEngine.TextGenerator gen_ret = new UnityEngine.TextGenerator(_initialCapacity);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.TextGenerator constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Invalidate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Invalidate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCharacters(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.UICharInfo> _characters = (System.Collections.Generic.List<UnityEngine.UICharInfo>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UICharInfo>));
                    
                    gen_to_be_invoked.GetCharacters( _characters );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLines(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.UILineInfo> _lines = (System.Collections.Generic.List<UnityEngine.UILineInfo>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UILineInfo>));
                    
                    gen_to_be_invoked.GetLines( _lines );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVertices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _vertices = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    
                    gen_to_be_invoked.GetVertices( _vertices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPreferredWidth(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.TextGenerationSettings _settings;translator.Get(L, 3, out _settings);
                    
                        float gen_ret = gen_to_be_invoked.GetPreferredWidth( _str, _settings );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPreferredHeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.TextGenerationSettings _settings;translator.Get(L, 3, out _settings);
                    
                        float gen_ret = gen_to_be_invoked.GetPreferredHeight( _str, _settings );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PopulateWithErrors(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.TextGenerationSettings _settings;translator.Get(L, 3, out _settings);
                    UnityEngine.GameObject _context = (UnityEngine.GameObject)translator.GetObject(L, 4, typeof(UnityEngine.GameObject));
                    
                        bool gen_ret = gen_to_be_invoked.PopulateWithErrors( _str, _settings, _context );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Populate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.TextGenerationSettings _settings;translator.Get(L, 3, out _settings);
                    
                        bool gen_ret = gen_to_be_invoked.Populate( _str, _settings );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVerticesArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.UIVertex[] gen_ret = gen_to_be_invoked.GetVerticesArray(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCharactersArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.UICharInfo[] gen_ret = gen_to_be_invoked.GetCharactersArray(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLinesArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.UILineInfo[] gen_ret = gen_to_be_invoked.GetLinesArray(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_characterCountVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.characterCountVisible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verts(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.verts);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_characters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.characters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lines(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.lines);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rectExtents(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rectExtents);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertexCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.vertexCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_characterCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.characterCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.lineCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontSizeUsedForBestFit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextGenerator gen_to_be_invoked = (UnityEngine.TextGenerator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.fontSizeUsedForBestFit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

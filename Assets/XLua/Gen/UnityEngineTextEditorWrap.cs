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
    public class UnityEngineTextEditorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.TextEditor);
			Utils.BeginObjectRegister(type, L, translator, 0, 64, 17, 15);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFocus", _m_OnFocus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLostFocus", _m_OnLostFocus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HandleKeyEvent", _m_HandleKeyEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeleteLineBack", _m_DeleteLineBack);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeleteWordBack", _m_DeleteWordBack);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeleteWordForward", _m_DeleteWordForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Delete", _m_Delete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanPaste", _m_CanPaste);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Backspace", _m_Backspace);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectAll", _m_SelectAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectNone", _m_SelectNone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeleteSelection", _m_DeleteSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReplaceSelection", _m_ReplaceSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Insert", _m_Insert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveSelectionToAltCursor", _m_MoveSelectionToAltCursor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveRight", _m_MoveRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveLeft", _m_MoveLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveUp", _m_MoveUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveDown", _m_MoveDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveLineStart", _m_MoveLineStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveLineEnd", _m_MoveLineEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveGraphicalLineStart", _m_MoveGraphicalLineStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveGraphicalLineEnd", _m_MoveGraphicalLineEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveTextStart", _m_MoveTextStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveTextEnd", _m_MoveTextEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveParagraphForward", _m_MoveParagraphForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveParagraphBackward", _m_MoveParagraphBackward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveCursorToPosition", _m_MoveCursorToPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveAltCursorToPosition", _m_MoveAltCursorToPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsOverSelection", _m_IsOverSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectToPosition", _m_SelectToPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectLeft", _m_SelectLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectRight", _m_SelectRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectUp", _m_SelectUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectDown", _m_SelectDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectTextEnd", _m_SelectTextEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectTextStart", _m_SelectTextStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MouseDragSelectsWholeWords", _m_MouseDragSelectsWholeWords);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DblClickSnap", _m_DblClickSnap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveWordRight", _m_MoveWordRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveToStartOfNextWord", _m_MoveToStartOfNextWord);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveToEndOfPreviousWord", _m_MoveToEndOfPreviousWord);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectToStartOfNextWord", _m_SelectToStartOfNextWord);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectToEndOfPreviousWord", _m_SelectToEndOfPreviousWord);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindStartOfNextWord", _m_FindStartOfNextWord);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveWordLeft", _m_MoveWordLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectWordRight", _m_SelectWordRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectWordLeft", _m_SelectWordLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExpandSelectGraphicalLineStart", _m_ExpandSelectGraphicalLineStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExpandSelectGraphicalLineEnd", _m_ExpandSelectGraphicalLineEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectGraphicalLineStart", _m_SelectGraphicalLineStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectGraphicalLineEnd", _m_SelectGraphicalLineEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectParagraphForward", _m_SelectParagraphForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectParagraphBackward", _m_SelectParagraphBackward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectCurrentWord", _m_SelectCurrentWord);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectCurrentParagraph", _m_SelectCurrentParagraph);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateScrollOffsetIfNeeded", _m_UpdateScrollOffsetIfNeeded);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawCursor", _m_DrawCursor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveBackup", _m_SaveBackup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Undo", _m_Undo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cut", _m_Cut);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Copy", _m_Copy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Paste", _m_Paste);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetectFocusChange", _m_DetectFocusChange);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", _g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", _g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cursorIndex", _g_get_cursorIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectIndex", _g_get_selectIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "doubleClickSnapping", _g_get_doubleClickSnapping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "altCursorPosition", _g_get_altCursorPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasSelection", _g_get_hasSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedText", _g_get_SelectedText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardOnScreen", _g_get_keyboardOnScreen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "controlID", _g_get_controlID);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "style", _g_get_style);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "multiline", _g_get_multiline);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasHorizontalCursorPos", _g_get_hasHorizontalCursorPos);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPasswordField", _g_get_isPasswordField);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollOffset", _g_get_scrollOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "graphicalCursorPos", _g_get_graphicalCursorPos);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "graphicalSelectCursorPos", _g_get_graphicalSelectCursorPos);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", _s_set_text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", _s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cursorIndex", _s_set_cursorIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectIndex", _s_set_selectIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "doubleClickSnapping", _s_set_doubleClickSnapping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "altCursorPosition", _s_set_altCursorPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardOnScreen", _s_set_keyboardOnScreen);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "controlID", _s_set_controlID);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "style", _s_set_style);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "multiline", _s_set_multiline);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hasHorizontalCursorPos", _s_set_hasHorizontalCursorPos);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isPasswordField", _s_set_isPasswordField);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollOffset", _s_set_scrollOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "graphicalCursorPos", _s_set_graphicalCursorPos);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "graphicalSelectCursorPos", _s_set_graphicalSelectCursorPos);
            
			
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
					
					UnityEngine.TextEditor gen_ret = new UnityEngine.TextEditor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.TextEditor constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFocus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnFocus(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLostFocus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnLostFocus(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HandleKeyEvent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Event _e = (UnityEngine.Event)translator.GetObject(L, 2, typeof(UnityEngine.Event));
                    
                        bool gen_ret = gen_to_be_invoked.HandleKeyEvent( _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteLineBack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.DeleteLineBack(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteWordBack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.DeleteWordBack(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteWordForward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.DeleteWordForward(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Delete(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.Delete(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanPaste(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.CanPaste(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Backspace(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.Backspace(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectAll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectNone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectNone(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeleteSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.DeleteSelection(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReplaceSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _replace = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.ReplaceSelection( _replace );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Insert(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    char _c = (char)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Insert( _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveSelectionToAltCursor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveSelectionToAltCursor(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveRight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveRight(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveLeft(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveLeft(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveUp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveUp(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveDown(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveDown(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveLineStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveLineStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveLineEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveLineEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveGraphicalLineStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveGraphicalLineStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveGraphicalLineEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveGraphicalLineEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveTextStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveTextStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveTextEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveTextEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveParagraphForward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveParagraphForward(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveParagraphBackward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveParagraphBackward(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveCursorToPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _cursorPosition;translator.Get(L, 2, out _cursorPosition);
                    
                    gen_to_be_invoked.MoveCursorToPosition( _cursorPosition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveAltCursorToPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _cursorPosition;translator.Get(L, 2, out _cursorPosition);
                    
                    gen_to_be_invoked.MoveAltCursorToPosition( _cursorPosition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsOverSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _cursorPosition;translator.Get(L, 2, out _cursorPosition);
                    
                        bool gen_ret = gen_to_be_invoked.IsOverSelection( _cursorPosition );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectToPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _cursorPosition;translator.Get(L, 2, out _cursorPosition);
                    
                    gen_to_be_invoked.SelectToPosition( _cursorPosition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectLeft(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectLeft(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectRight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectRight(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectUp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectUp(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectDown(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectDown(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectTextEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectTextEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectTextStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectTextStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MouseDragSelectsWholeWords(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _on = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.MouseDragSelectsWholeWords( _on );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DblClickSnap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.TextEditor.DblClickSnapping _snapping;translator.Get(L, 2, out _snapping);
                    
                    gen_to_be_invoked.DblClickSnap( _snapping );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveWordRight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveWordRight(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveToStartOfNextWord(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveToStartOfNextWord(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveToEndOfPreviousWord(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveToEndOfPreviousWord(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectToStartOfNextWord(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectToStartOfNextWord(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectToEndOfPreviousWord(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectToEndOfPreviousWord(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindStartOfNextWord(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _p = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.FindStartOfNextWord( _p );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveWordLeft(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveWordLeft(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectWordRight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectWordRight(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectWordLeft(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectWordLeft(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExpandSelectGraphicalLineStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ExpandSelectGraphicalLineStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExpandSelectGraphicalLineEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ExpandSelectGraphicalLineEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectGraphicalLineStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectGraphicalLineStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectGraphicalLineEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectGraphicalLineEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectParagraphForward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectParagraphForward(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectParagraphBackward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectParagraphBackward(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectCurrentWord(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectCurrentWord(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectCurrentParagraph(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SelectCurrentParagraph(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateScrollOffsetIfNeeded(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Event _evt = (UnityEngine.Event)translator.GetObject(L, 2, typeof(UnityEngine.Event));
                    
                    gen_to_be_invoked.UpdateScrollOffsetIfNeeded( _evt );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawCursor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _newText = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.DrawCursor( _newText );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveBackup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SaveBackup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Undo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Undo(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cut(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.Cut(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Copy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Copy(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Paste(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.Paste(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DetectFocusChange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DetectFocusChange(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.position);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cursorIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.cursorIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.selectIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_doubleClickSnapping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.doubleClickSnapping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_altCursorPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.altCursorPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasSelection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectedText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.SelectedText);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardOnScreen(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.keyboardOnScreen);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controlID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.controlID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_style(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.style);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_multiline(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.multiline);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasHorizontalCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasHorizontalCursorPos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPasswordField(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPasswordField);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.scrollOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicalCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.graphicalCursorPos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicalSelectCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.graphicalSelectCursorPos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.text = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.position = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cursorIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cursorIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_doubleClickSnapping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                UnityEngine.TextEditor.DblClickSnapping gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.doubleClickSnapping = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_altCursorPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.altCursorPosition = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardOnScreen(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardOnScreen = (UnityEngine.TouchScreenKeyboard)translator.GetObject(L, 2, typeof(UnityEngine.TouchScreenKeyboard));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_controlID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.controlID = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_style(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_multiline(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.multiline = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hasHorizontalCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hasHorizontalCursorPos = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isPasswordField(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isPasswordField = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.scrollOffset = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_graphicalCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.graphicalCursorPos = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_graphicalSelectCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TextEditor gen_to_be_invoked = (UnityEngine.TextEditor)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.graphicalSelectCursorPos = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

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
    public class UnityEngineSocialWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Social);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadUsers", _m_LoadUsers_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReportProgress", _m_ReportProgress_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAchievementDescriptions", _m_LoadAchievementDescriptions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAchievements", _m_LoadAchievements_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReportScore", _m_ReportScore_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadScores", _m_LoadScores_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateLeaderboard", _m_CreateLeaderboard_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateAchievement", _m_CreateAchievement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ShowAchievementsUI", _m_ShowAchievementsUI_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ShowLeaderboardUI", _m_ShowLeaderboardUI_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Active", _g_get_Active);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "localUser", _g_get_localUser);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Active", _s_set_Active);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Social does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadUsers_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string[] _userIDs = (string[])translator.GetObject(L, 1, typeof(string[]));
                    System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> _callback = translator.GetDelegate<System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>>(L, 2);
                    
                    UnityEngine.Social.LoadUsers( _userIDs, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReportProgress_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _achievementID = LuaAPI.lua_tostring(L, 1);
                    double _progress = LuaAPI.lua_tonumber(L, 2);
                    System.Action<bool> _callback = translator.GetDelegate<System.Action<bool>>(L, 3);
                    
                    UnityEngine.Social.ReportProgress( _achievementID, _progress, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAchievementDescriptions_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> _callback = translator.GetDelegate<System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>>(L, 1);
                    
                    UnityEngine.Social.LoadAchievementDescriptions( _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAchievements_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Action<UnityEngine.SocialPlatforms.IAchievement[]> _callback = translator.GetDelegate<System.Action<UnityEngine.SocialPlatforms.IAchievement[]>>(L, 1);
                    
                    UnityEngine.Social.LoadAchievements( _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReportScore_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    long _score = LuaAPI.lua_toint64(L, 1);
                    string _board = LuaAPI.lua_tostring(L, 2);
                    System.Action<bool> _callback = translator.GetDelegate<System.Action<bool>>(L, 3);
                    
                    UnityEngine.Social.ReportScore( _score, _board, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadScores_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _leaderboardID = LuaAPI.lua_tostring(L, 1);
                    System.Action<UnityEngine.SocialPlatforms.IScore[]> _callback = translator.GetDelegate<System.Action<UnityEngine.SocialPlatforms.IScore[]>>(L, 2);
                    
                    UnityEngine.Social.LoadScores( _leaderboardID, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateLeaderboard_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        UnityEngine.SocialPlatforms.ILeaderboard gen_ret = UnityEngine.Social.CreateLeaderboard(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateAchievement_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        UnityEngine.SocialPlatforms.IAchievement gen_ret = UnityEngine.Social.CreateAchievement(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowAchievementsUI_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Social.ShowAchievementsUI(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowLeaderboardUI_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Social.ShowLeaderboardUI(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Active(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushAny(L, UnityEngine.Social.Active);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localUser(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushAny(L, UnityEngine.Social.localUser);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Active(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    UnityEngine.Social.Active = (UnityEngine.SocialPlatforms.ISocialPlatform)translator.GetObject(L, 1, typeof(UnityEngine.SocialPlatforms.ISocialPlatform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

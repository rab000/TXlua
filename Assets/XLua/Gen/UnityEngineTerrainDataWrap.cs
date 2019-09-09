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
    public class UnityEngineTerrainDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.TerrainData);
			Utils.BeginObjectRegister(type, L, translator, 0, 23, 29, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDirtyRegion", _m_UpdateDirtyRegion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHeight", _m_GetHeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInterpolatedHeight", _m_GetInterpolatedHeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHeights", _m_GetHeights);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetHeights", _m_SetHeights);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPatchMinMaxHeights", _m_GetPatchMinMaxHeights);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverrideMinMaxPatchHeights", _m_OverrideMinMaxPatchHeights);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMaximumHeightError", _m_GetMaximumHeightError);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverrideMaximumHeightError", _m_OverrideMaximumHeightError);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetHeightsDelayLOD", _m_SetHeightsDelayLOD);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSteepness", _m_GetSteepness);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInterpolatedNormal", _m_GetInterpolatedNormal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDetailResolution", _m_SetDetailResolution);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RefreshPrototypes", _m_RefreshPrototypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSupportedLayers", _m_GetSupportedLayers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDetailLayer", _m_GetDetailLayer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDetailLayer", _m_SetDetailLayer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTreeInstance", _m_GetTreeInstance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTreeInstance", _m_SetTreeInstance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAlphamaps", _m_GetAlphamaps);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAlphamaps", _m_SetAlphamaps);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBaseMapDirty", _m_SetBaseMapDirty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAlphamapTexture", _m_GetAlphamapTexture);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "heightmapWidth", _g_get_heightmapWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "heightmapHeight", _g_get_heightmapHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "heightmapTexture", _g_get_heightmapTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "heightmapResolution", _g_get_heightmapResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "heightmapScale", _g_get_heightmapScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "size", _g_get_size);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bounds", _g_get_bounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "thickness", _g_get_thickness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wavingGrassStrength", _g_get_wavingGrassStrength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wavingGrassAmount", _g_get_wavingGrassAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wavingGrassSpeed", _g_get_wavingGrassSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wavingGrassTint", _g_get_wavingGrassTint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailWidth", _g_get_detailWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailHeight", _g_get_detailHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailPatchCount", _g_get_detailPatchCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailResolution", _g_get_detailResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailResolutionPerPatch", _g_get_detailResolutionPerPatch);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailPrototypes", _g_get_detailPrototypes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treeInstances", _g_get_treeInstances);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treeInstanceCount", _g_get_treeInstanceCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treePrototypes", _g_get_treePrototypes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphamapLayers", _g_get_alphamapLayers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphamapResolution", _g_get_alphamapResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphamapWidth", _g_get_alphamapWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphamapHeight", _g_get_alphamapHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "baseMapResolution", _g_get_baseMapResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphamapTextureCount", _g_get_alphamapTextureCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphamapTextures", _g_get_alphamapTextures);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "terrainLayers", _g_get_terrainLayers);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "heightmapResolution", _s_set_heightmapResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "size", _s_set_size);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "thickness", _s_set_thickness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wavingGrassStrength", _s_set_wavingGrassStrength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wavingGrassAmount", _s_set_wavingGrassAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wavingGrassSpeed", _s_set_wavingGrassSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wavingGrassTint", _s_set_wavingGrassTint);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "detailPrototypes", _s_set_detailPrototypes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treeInstances", _s_set_treeInstances);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treePrototypes", _s_set_treePrototypes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alphamapResolution", _s_set_alphamapResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "baseMapResolution", _s_set_baseMapResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "terrainLayers", _s_set_terrainLayers);
            
			
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
					
					UnityEngine.TerrainData gen_ret = new UnityEngine.TerrainData();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.TerrainData constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDirtyRegion(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    int _width = LuaAPI.xlua_tointeger(L, 4);
                    int _height = LuaAPI.xlua_tointeger(L, 5);
                    bool _syncHeightmapTextureImmediately = LuaAPI.lua_toboolean(L, 6);
                    
                    gen_to_be_invoked.UpdateDirtyRegion( _x, _y, _width, _height, _syncHeightmapTextureImmediately );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    
                        float gen_ret = gen_to_be_invoked.GetHeight( _x, _y );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterpolatedHeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        float gen_ret = gen_to_be_invoked.GetInterpolatedHeight( _x, _y );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHeights(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _xBase = LuaAPI.xlua_tointeger(L, 2);
                    int _yBase = LuaAPI.xlua_tointeger(L, 3);
                    int _width = LuaAPI.xlua_tointeger(L, 4);
                    int _height = LuaAPI.xlua_tointeger(L, 5);
                    
                        float[,] gen_ret = gen_to_be_invoked.GetHeights( _xBase, _yBase, _width, _height );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetHeights(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _xBase = LuaAPI.xlua_tointeger(L, 2);
                    int _yBase = LuaAPI.xlua_tointeger(L, 3);
                    float[,] _heights = (float[,])translator.GetObject(L, 4, typeof(float[,]));
                    
                    gen_to_be_invoked.SetHeights( _xBase, _yBase, _heights );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPatchMinMaxHeights(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.PatchExtents[] gen_ret = gen_to_be_invoked.GetPatchMinMaxHeights(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverrideMinMaxPatchHeights(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.PatchExtents[] _minMaxHeights = (UnityEngine.PatchExtents[])translator.GetObject(L, 2, typeof(UnityEngine.PatchExtents[]));
                    
                    gen_to_be_invoked.OverrideMinMaxPatchHeights( _minMaxHeights );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMaximumHeightError(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        float[] gen_ret = gen_to_be_invoked.GetMaximumHeightError(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverrideMaximumHeightError(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float[] _maxError = (float[])translator.GetObject(L, 2, typeof(float[]));
                    
                    gen_to_be_invoked.OverrideMaximumHeightError( _maxError );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetHeightsDelayLOD(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _xBase = LuaAPI.xlua_tointeger(L, 2);
                    int _yBase = LuaAPI.xlua_tointeger(L, 3);
                    float[,] _heights = (float[,])translator.GetObject(L, 4, typeof(float[,]));
                    
                    gen_to_be_invoked.SetHeightsDelayLOD( _xBase, _yBase, _heights );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSteepness(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        float gen_ret = gen_to_be_invoked.GetSteepness( _x, _y );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterpolatedNormal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector3 gen_ret = gen_to_be_invoked.GetInterpolatedNormal( _x, _y );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDetailResolution(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _detailResolution = LuaAPI.xlua_tointeger(L, 2);
                    int _resolutionPerPatch = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetDetailResolution( _detailResolution, _resolutionPerPatch );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RefreshPrototypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RefreshPrototypes(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSupportedLayers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _xBase = LuaAPI.xlua_tointeger(L, 2);
                    int _yBase = LuaAPI.xlua_tointeger(L, 3);
                    int _totalWidth = LuaAPI.xlua_tointeger(L, 4);
                    int _totalHeight = LuaAPI.xlua_tointeger(L, 5);
                    
                        int[] gen_ret = gen_to_be_invoked.GetSupportedLayers( _xBase, _yBase, _totalWidth, _totalHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDetailLayer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _xBase = LuaAPI.xlua_tointeger(L, 2);
                    int _yBase = LuaAPI.xlua_tointeger(L, 3);
                    int _width = LuaAPI.xlua_tointeger(L, 4);
                    int _height = LuaAPI.xlua_tointeger(L, 5);
                    int _layer = LuaAPI.xlua_tointeger(L, 6);
                    
                        int[,] gen_ret = gen_to_be_invoked.GetDetailLayer( _xBase, _yBase, _width, _height, _layer );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDetailLayer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _xBase = LuaAPI.xlua_tointeger(L, 2);
                    int _yBase = LuaAPI.xlua_tointeger(L, 3);
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    int[,] _details = (int[,])translator.GetObject(L, 5, typeof(int[,]));
                    
                    gen_to_be_invoked.SetDetailLayer( _xBase, _yBase, _layer, _details );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTreeInstance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.TreeInstance gen_ret = gen_to_be_invoked.GetTreeInstance( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTreeInstance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.TreeInstance _instance;translator.Get(L, 3, out _instance);
                    
                    gen_to_be_invoked.SetTreeInstance( _index, _instance );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAlphamaps(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    int _width = LuaAPI.xlua_tointeger(L, 4);
                    int _height = LuaAPI.xlua_tointeger(L, 5);
                    
                        float[,,] gen_ret = gen_to_be_invoked.GetAlphamaps( _x, _y, _width, _height );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAlphamaps(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    float[,,] _map = (float[,,])translator.GetObject(L, 4, typeof(float[,,]));
                    
                    gen_to_be_invoked.SetAlphamaps( _x, _y, _map );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBaseMapDirty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SetBaseMapDirty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAlphamapTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Texture2D gen_ret = gen_to_be_invoked.GetAlphamapTexture( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.heightmapWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.heightmapHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.heightmapTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.heightmapResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.heightmapScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_size(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.size);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bounds(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, gen_to_be_invoked.bounds);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_thickness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.thickness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wavingGrassStrength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.wavingGrassStrength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wavingGrassAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.wavingGrassAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wavingGrassSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.wavingGrassSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wavingGrassTint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.wavingGrassTint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.detailWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.detailHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailPatchCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.detailPatchCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.detailResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailResolutionPerPatch(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.detailResolutionPerPatch);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailPrototypes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.detailPrototypes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treeInstances(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.treeInstances);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treeInstanceCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.treeInstanceCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treePrototypes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.treePrototypes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphamapLayers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.alphamapLayers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphamapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.alphamapResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphamapWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.alphamapWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphamapHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.alphamapHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baseMapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.baseMapResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphamapTextureCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.alphamapTextureCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphamapTextures(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.alphamapTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_terrainLayers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.terrainLayers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_heightmapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.heightmapResolution = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_size(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.size = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_thickness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.thickness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wavingGrassStrength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.wavingGrassStrength = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wavingGrassAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.wavingGrassAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wavingGrassSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.wavingGrassSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wavingGrassTint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.wavingGrassTint = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_detailPrototypes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.detailPrototypes = (UnityEngine.DetailPrototype[])translator.GetObject(L, 2, typeof(UnityEngine.DetailPrototype[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treeInstances(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treeInstances = (UnityEngine.TreeInstance[])translator.GetObject(L, 2, typeof(UnityEngine.TreeInstance[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treePrototypes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treePrototypes = (UnityEngine.TreePrototype[])translator.GetObject(L, 2, typeof(UnityEngine.TreePrototype[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alphamapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.alphamapResolution = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baseMapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.baseMapResolution = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_terrainLayers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.TerrainData gen_to_be_invoked = (UnityEngine.TerrainData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.terrainLayers = (UnityEngine.TerrainLayer[])translator.GetObject(L, 2, typeof(UnityEngine.TerrainLayer[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

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
using UnityEngine;

namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineTerrainWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Terrain);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 38, 33);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClosestReflectionProbes", _m_GetClosestReflectionProbes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SampleHeight", _m_SampleHeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyDelayedHeightmapModification", _m_ApplyDelayedHeightmapModification);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTreeInstance", _m_AddTreeInstance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNeighbors", _m_SetNeighbors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPosition", _m_GetPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Flush", _m_Flush);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSplatMaterialPropertyBlock", _m_SetSplatMaterialPropertyBlock);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSplatMaterialPropertyBlock", _m_GetSplatMaterialPropertyBlock);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateGIMaterials", _m_UpdateGIMaterials);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "terrainData", _g_get_terrainData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treeDistance", _g_get_treeDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treeBillboardDistance", _g_get_treeBillboardDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treeCrossFadeLength", _g_get_treeCrossFadeLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treeMaximumFullLODCount", _g_get_treeMaximumFullLODCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailObjectDistance", _g_get_detailObjectDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detailObjectDensity", _g_get_detailObjectDensity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "heightmapPixelError", _g_get_heightmapPixelError);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "heightmapMaximumLOD", _g_get_heightmapMaximumLOD);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "basemapDistance", _g_get_basemapDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapIndex", _g_get_lightmapIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeLightmapIndex", _g_get_realtimeLightmapIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapScaleOffset", _g_get_lightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeLightmapScaleOffset", _g_get_realtimeLightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "freeUnusedRenderingResources", _g_get_freeUnusedRenderingResources);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "castShadows", _g_get_castShadows);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reflectionProbeUsage", _g_get_reflectionProbeUsage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materialType", _g_get_materialType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materialTemplate", _g_get_materialTemplate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "legacySpecular", _g_get_legacySpecular);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "legacyShininess", _g_get_legacyShininess);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawHeightmap", _g_get_drawHeightmap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowAutoConnect", _g_get_allowAutoConnect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "groupingID", _g_get_groupingID);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawInstanced", _g_get_drawInstanced);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalmapTexture", _g_get_normalmapTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawTreesAndFoliage", _g_get_drawTreesAndFoliage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "patchBoundsMultiplier", _g_get_patchBoundsMultiplier);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treeLODBiasMultiplier", _g_get_treeLODBiasMultiplier);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collectDetailPatches", _g_get_collectDetailPatches);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "editorRenderFlags", _g_get_editorRenderFlags);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bakeLightProbesForTrees", _g_get_bakeLightProbesForTrees);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deringLightProbesForTrees", _g_get_deringLightProbesForTrees);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preserveTreePrototypeLayers", _g_get_preserveTreePrototypeLayers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftNeighbor", _g_get_leftNeighbor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightNeighbor", _g_get_rightNeighbor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "topNeighbor", _g_get_topNeighbor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bottomNeighbor", _g_get_bottomNeighbor);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "terrainData", _s_set_terrainData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treeDistance", _s_set_treeDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treeBillboardDistance", _s_set_treeBillboardDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treeCrossFadeLength", _s_set_treeCrossFadeLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treeMaximumFullLODCount", _s_set_treeMaximumFullLODCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "detailObjectDistance", _s_set_detailObjectDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "detailObjectDensity", _s_set_detailObjectDensity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "heightmapPixelError", _s_set_heightmapPixelError);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "heightmapMaximumLOD", _s_set_heightmapMaximumLOD);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "basemapDistance", _s_set_basemapDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapIndex", _s_set_lightmapIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeLightmapIndex", _s_set_realtimeLightmapIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapScaleOffset", _s_set_lightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeLightmapScaleOffset", _s_set_realtimeLightmapScaleOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "freeUnusedRenderingResources", _s_set_freeUnusedRenderingResources);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "castShadows", _s_set_castShadows);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reflectionProbeUsage", _s_set_reflectionProbeUsage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materialType", _s_set_materialType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materialTemplate", _s_set_materialTemplate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "legacySpecular", _s_set_legacySpecular);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "legacyShininess", _s_set_legacyShininess);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawHeightmap", _s_set_drawHeightmap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowAutoConnect", _s_set_allowAutoConnect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "groupingID", _s_set_groupingID);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawInstanced", _s_set_drawInstanced);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawTreesAndFoliage", _s_set_drawTreesAndFoliage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "patchBoundsMultiplier", _s_set_patchBoundsMultiplier);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treeLODBiasMultiplier", _s_set_treeLODBiasMultiplier);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "collectDetailPatches", _s_set_collectDetailPatches);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "editorRenderFlags", _s_set_editorRenderFlags);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bakeLightProbesForTrees", _s_set_bakeLightProbesForTrees);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "deringLightProbesForTrees", _s_set_deringLightProbesForTrees);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "preserveTreePrototypeLayers", _s_set_preserveTreePrototypeLayers);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 4, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetConnectivityDirty", _m_SetConnectivityDirty_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateTerrainGameObject", _m_CreateTerrainGameObject_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "heightmapTextureFormat", _g_get_heightmapTextureFormat);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "heightmapRenderTextureFormat", _g_get_heightmapRenderTextureFormat);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeTerrain", _g_get_activeTerrain);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeTerrains", _g_get_activeTerrains);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Terrain gen_ret = new UnityEngine.Terrain();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Terrain constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClosestReflectionProbes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> _result = (System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>));
                    
                    gen_to_be_invoked.GetClosestReflectionProbes( _result );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SampleHeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _worldPosition;translator.Get(L, 2, out _worldPosition);
                    
                        float gen_ret = gen_to_be_invoked.SampleHeight( _worldPosition );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyDelayedHeightmapModification(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ApplyDelayedHeightmapModification(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTreeInstance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.TreeInstance _instance;translator.Get(L, 2, out _instance);
                    
                    gen_to_be_invoked.AddTreeInstance( _instance );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetNeighbors(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Terrain _left = (UnityEngine.Terrain)translator.GetObject(L, 2, typeof(UnityEngine.Terrain));
                    UnityEngine.Terrain _top = (UnityEngine.Terrain)translator.GetObject(L, 3, typeof(UnityEngine.Terrain));
                    UnityEngine.Terrain _right = (UnityEngine.Terrain)translator.GetObject(L, 4, typeof(UnityEngine.Terrain));
                    UnityEngine.Terrain _bottom = (UnityEngine.Terrain)translator.GetObject(L, 5, typeof(UnityEngine.Terrain));
                    
                    gen_to_be_invoked.SetNeighbors( _left, _top, _right, _bottom );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.Vector3 gen_ret = gen_to_be_invoked.GetPosition(  );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Flush(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Flush(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSplatMaterialPropertyBlock(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    gen_to_be_invoked.SetSplatMaterialPropertyBlock( _properties );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSplatMaterialPropertyBlock(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.MaterialPropertyBlock _dest = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 2, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    gen_to_be_invoked.GetSplatMaterialPropertyBlock( _dest );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetConnectivityDirty_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Terrain.SetConnectivityDirty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateTerrainGameObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.TerrainData _assignTerrain = (UnityEngine.TerrainData)translator.GetObject(L, 1, typeof(UnityEngine.TerrainData));
                    
                        UnityEngine.GameObject gen_ret = UnityEngine.Terrain.CreateTerrainGameObject( _assignTerrain );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateGIMaterials(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.UpdateGIMaterials(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    int _width = LuaAPI.xlua_tointeger(L, 4);
                    int _height = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.UpdateGIMaterials( _x, _y, _width, _height );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Terrain.UpdateGIMaterials!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_terrainData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.terrainData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treeDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.treeDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treeBillboardDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.treeBillboardDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treeCrossFadeLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.treeCrossFadeLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treeMaximumFullLODCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.treeMaximumFullLODCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailObjectDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.detailObjectDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detailObjectDensity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.detailObjectDensity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapPixelError(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.heightmapPixelError);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapMaximumLOD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.heightmapMaximumLOD);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_basemapDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.basemapDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightmapIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.lightmapIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_realtimeLightmapIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.realtimeLightmapIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightmapScaleOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, gen_to_be_invoked.lightmapScaleOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_realtimeLightmapScaleOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, gen_to_be_invoked.realtimeLightmapScaleOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_freeUnusedRenderingResources(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.freeUnusedRenderingResources);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_castShadows(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.castShadows);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reflectionProbeUsage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.reflectionProbeUsage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_materialType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.materialType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_materialTemplate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.materialTemplate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_legacySpecular(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.legacySpecular);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_legacyShininess(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.legacyShininess);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawHeightmap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.drawHeightmap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowAutoConnect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowAutoConnect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_groupingID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.groupingID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawInstanced(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.drawInstanced);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normalmapTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.normalmapTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawTreesAndFoliage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.drawTreesAndFoliage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_patchBoundsMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.patchBoundsMultiplier);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treeLODBiasMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.treeLODBiasMultiplier);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_collectDetailPatches(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.collectDetailPatches);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_editorRenderFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.editorRenderFlags);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bakeLightProbesForTrees(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.bakeLightProbesForTrees);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deringLightProbesForTrees(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.deringLightProbesForTrees);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_preserveTreePrototypeLayers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.preserveTreePrototypeLayers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapTextureFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Terrain.heightmapTextureFormat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_heightmapRenderTextureFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Terrain.heightmapRenderTextureFormat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeTerrain(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Terrain.activeTerrain);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeTerrains(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Terrain.activeTerrains);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftNeighbor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.leftNeighbor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightNeighbor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rightNeighbor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_topNeighbor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.topNeighbor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bottomNeighbor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bottomNeighbor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_terrainData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.terrainData = (UnityEngine.TerrainData)translator.GetObject(L, 2, typeof(UnityEngine.TerrainData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treeDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treeDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treeBillboardDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treeBillboardDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treeCrossFadeLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treeCrossFadeLength = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treeMaximumFullLODCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treeMaximumFullLODCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_detailObjectDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.detailObjectDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_detailObjectDensity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.detailObjectDensity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_heightmapPixelError(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.heightmapPixelError = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_heightmapMaximumLOD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.heightmapMaximumLOD = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_basemapDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.basemapDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightmapIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lightmapIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_realtimeLightmapIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.realtimeLightmapIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightmapScaleOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.lightmapScaleOffset = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_realtimeLightmapScaleOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.realtimeLightmapScaleOffset = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_freeUnusedRenderingResources(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.freeUnusedRenderingResources = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_castShadows(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.castShadows = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reflectionProbeUsage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                UnityEngine.Rendering.ReflectionProbeUsage gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.reflectionProbeUsage = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_materialType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                UnityEngine.Terrain.MaterialType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.materialType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_materialTemplate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.materialTemplate = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_legacySpecular(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.legacySpecular = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_legacyShininess(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.legacyShininess = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawHeightmap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.drawHeightmap = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowAutoConnect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowAutoConnect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_groupingID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.groupingID = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawInstanced(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.drawInstanced = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawTreesAndFoliage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.drawTreesAndFoliage = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_patchBoundsMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.patchBoundsMultiplier = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treeLODBiasMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treeLODBiasMultiplier = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_collectDetailPatches(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.collectDetailPatches = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_editorRenderFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                UnityEngine.TerrainRenderFlags gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.editorRenderFlags = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bakeLightProbesForTrees(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bakeLightProbesForTrees = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_deringLightProbesForTrees(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.deringLightProbesForTrees = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_preserveTreePrototypeLayers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Terrain gen_to_be_invoked = (UnityEngine.Terrain)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.preserveTreePrototypeLayers = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

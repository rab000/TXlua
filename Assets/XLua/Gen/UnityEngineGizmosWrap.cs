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
    public class UnityEngineGizmosWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Gizmos);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 12, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawLine", _m_DrawLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawWireSphere", _m_DrawWireSphere_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawSphere", _m_DrawSphere_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawWireCube", _m_DrawWireCube_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawCube", _m_DrawCube_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMesh", _m_DrawMesh_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawWireMesh", _m_DrawWireMesh_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawIcon", _m_DrawIcon_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawGUITexture", _m_DrawGUITexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawFrustum", _m_DrawFrustum_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawRay", _m_DrawRay_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "color", _g_get_color);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "matrix", _g_get_matrix);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "color", _s_set_color);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "matrix", _s_set_matrix);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Gizmos gen_ret = new UnityEngine.Gizmos();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Gizmos constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawLine_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector3 _to;translator.Get(L, 2, out _to);
                    
                    UnityEngine.Gizmos.DrawLine( _from, _to );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawWireSphere_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Gizmos.DrawWireSphere( _center, _radius );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawSphere_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Gizmos.DrawSphere( _center, _radius );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawWireCube_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 1, out _center);
                    UnityEngine.Vector3 _size;translator.Get(L, 2, out _size);
                    
                    UnityEngine.Gizmos.DrawWireCube( _center, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawCube_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 1, out _center);
                    UnityEngine.Vector3 _size;translator.Get(L, 2, out _size);
                    
                    UnityEngine.Gizmos.DrawCube( _center, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMesh_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Mesh>(L, 1)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh, _submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh, _position );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh, _submeshIndex, _position );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh, _position, _rotation );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 4, out _rotation);
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh, _submeshIndex, _position, _rotation );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Vector3 _scale;translator.Get(L, 4, out _scale);
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh, _position, _rotation, _scale );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 4, out _rotation);
                    UnityEngine.Vector3 _scale;translator.Get(L, 5, out _scale);
                    
                    UnityEngine.Gizmos.DrawMesh( _mesh, _submeshIndex, _position, _rotation, _scale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Gizmos.DrawMesh!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawWireMesh_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Mesh>(L, 1)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh, _submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh, _position );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh, _submeshIndex, _position );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh, _position, _rotation );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 4, out _rotation);
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh, _submeshIndex, _position, _rotation );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Vector3 _scale;translator.Get(L, 4, out _scale);
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh, _position, _rotation, _scale );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Quaternion>(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 4, out _rotation);
                    UnityEngine.Vector3 _scale;translator.Get(L, 5, out _scale);
                    
                    UnityEngine.Gizmos.DrawWireMesh( _mesh, _submeshIndex, _position, _rotation, _scale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Gizmos.DrawWireMesh!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawIcon_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 1, out _center);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.Gizmos.DrawIcon( _center, _name );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 1, out _center);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    bool _allowScaling = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Gizmos.DrawIcon( _center, _name, _allowScaling );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Gizmos.DrawIcon!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawGUITexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Gizmos.DrawGUITexture( _screenRect, _texture );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Gizmos.DrawGUITexture( _screenRect, _texture, _leftBorder, _rightBorder, _topBorder, _bottomBorder );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    
                    UnityEngine.Gizmos.DrawGUITexture( _screenRect, _texture, _mat );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Material>(L, 7)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 7, typeof(UnityEngine.Material));
                    
                    UnityEngine.Gizmos.DrawGUITexture( _screenRect, _texture, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _mat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Gizmos.DrawGUITexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawFrustum_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 1, out _center);
                    float _fov = (float)LuaAPI.lua_tonumber(L, 2);
                    float _maxRange = (float)LuaAPI.lua_tonumber(L, 3);
                    float _minRange = (float)LuaAPI.lua_tonumber(L, 4);
                    float _aspect = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    UnityEngine.Gizmos.DrawFrustum( _center, _fov, _maxRange, _minRange, _aspect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawRay_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray _r;translator.Get(L, 1, out _r);
                    
                    UnityEngine.Gizmos.DrawRay( _r );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
                    
                    UnityEngine.Gizmos.DrawRay( _from, _direction );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Gizmos.DrawRay!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_color(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.Gizmos.color);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_matrix(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Gizmos.matrix);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_color(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Gizmos.color = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_matrix(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Matrix4x4 gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Gizmos.matrix = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

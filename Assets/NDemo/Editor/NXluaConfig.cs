﻿
using System.Collections.Generic;
using System;
using XLua;
using System.Reflection;
using System.Linq;

public static class NXluaConfig
{
    /// <summary>
    /// LuaCallCSharp白名单
    /// </summary>
    [LuaCallCSharp]
    public static IEnumerable<Type> LuaCallCSharp
    {
        get
        {
            List<string> namespaces = new List<string>() // 在这里添加名字空间
            {
                "UnityEngine",
                "UnityEngine.UI"
            };
            var unityTypes = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                              where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
                              from type in assembly.GetExportedTypes()
                              where type.Namespace != null && namespaces.Contains(type.Namespace) && !isExcluded(type)
                                      && type.BaseType != typeof(MulticastDelegate) && !type.IsInterface && !type.IsEnum
                              select type);

            string[] customAssemblys = new string[] {
                "Assembly-CSharp",
            };
            var customTypes = (from assembly in customAssemblys.Select(s => Assembly.Load(s))
                               from type in assembly.GetExportedTypes()
                               where type.Namespace == null || !type.Namespace.StartsWith("XLua")
                                       && type.BaseType != typeof(MulticastDelegate) && !type.IsInterface && !type.IsEnum
                               select type);
            return unityTypes.Concat(customTypes);
        }
    }

    //自动把LuaCallCSharp涉及到的delegate加到CSharpCallLua列表，后续可以直接用lua函数做callback
    //[CSharpCallLua]
    //public static List<Type> CSharpCallLua
    //{
    //    get
    //    {
    //        var lua_call_csharp = LuaCallCSharp;
    //        var delegate_types = new List<Type>();
    //        var flag = BindingFlags.Public | BindingFlags.Instance
    //            | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly;
    //        foreach (var field in (from type in lua_call_csharp select type).SelectMany(type => type.GetFields(flag)))
    //        {
    //            if (typeof(Delegate).IsAssignableFrom(field.FieldType))
    //            {
    //                delegate_types.Add(field.FieldType);
    //            }
    //        }

    //        foreach (var method in (from type in lua_call_csharp select type).SelectMany(type => type.GetMethods(flag)))
    //        {
    //            if (typeof(Delegate).IsAssignableFrom(method.ReturnType))
    //            {
    //                delegate_types.Add(method.ReturnType);
    //            }
    //            foreach (var param in method.GetParameters())
    //            {
    //                var paramType = param.ParameterType.IsByRef ? param.ParameterType.GetElementType() : param.ParameterType;
    //                if (typeof(Delegate).IsAssignableFrom(paramType))
    //                {
    //                    delegate_types.Add(paramType);
    //                }
    //            }
    //        }
    //        return delegate_types.Distinct().ToList();
    //    }
    //}

    //[Hotfix]
    //public static List<Type> hotfixList
    //{
    //    get
    //    {
    //        string[] allowNamespaces = new string[] {
    //                "NTHotfix",
    //        };

    //        return (from type in Assembly.Load("Assembly-CSharp").GetTypes()
    //                where allowNamespaces.Contains(type.Namespace)
    //                select type).ToList();
    //    }

    //}

    [Hotfix]
    public static List<Type> by_field = new List<Type>()
    {
        typeof(NTHotfix.CSharpMono4Hotfix),
        //typeof(GenericClass<>),
    };

    //[Hotfix]
    //public static List<Type> by_property
    //{
    //    get
    //    {
    //        return (from type in Assembly.Load("Assembly-CSharp").GetTypes()
    //                where type.Namespace == "NTHotfix"
    //                select type).ToList();
    //    }
    //}


    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
                new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
                new List<string>(){"UnityEngine.WWW", "movie"},
    #if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"},
    #endif
                new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
                new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
                new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
                new List<string>(){"UnityEngine.Light", "areaSize"},
                new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
                new List<string>(){"UnityEngine.WWW", "MovieTexture"},
                new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
                new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
    #if !UNITY_WEBPLAYER
                new List<string>(){"UnityEngine.Application", "ExternalEval"},
    #endif
                new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
                new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
                new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
            };

    static bool isExcluded(Type type)
    {
        var fullName = type.FullName;
        for (int i = 0; i < exclude.Count; i++)
        {
            if (fullName.Contains(exclude[i]))
            {
                return true;
            }
        }
        return false;
    }

    static List<string> exclude = new List<string>
    {
        //    "HideInInspector", "ExecuteInEditMode",
        //    "AddComponentMenu", "ContextMenu",
        //    "RequireComponent", "DisallowMultipleComponent",
        //    "SerializeField", "AssemblyIsEditorAssembly",
        //    "Attribute", "Types",
        //    "UnitySurrogateSelector", "TrackedReference",
        //    "TypeInferenceRules", "FFTWindow",
        //    "RPC", "Network", "MasterServer",
        //    "BitStream", "HostData",
        //    "ConnectionTesterStatus", "GUI", "EventType",
        //    "EventModifiers", "FontStyle", "TextAlignment",
        //    "TextEditor", "TextEditorDblClickSnapping",
        //    "TextGenerator", "TextClipping", "Gizmos",
        //    "ADBannerView", "ADInterstitialAd",
        //    "Android", "Tizen", "jvalue",
        //    "iPhone", "iOS", "Windows", "CalendarIdentifier",
        //    "CalendarUnit", "CalendarUnit",
        //    "ClusterInput", "FullScreenMovieControlMode",
        //    "FullScreenMovieScalingMode", "Handheld",
        //    "LocalNotification", "NotificationServices",
        //    "RemoteNotificationType", "RemoteNotification",
        //    "SamsungTV", "TextureCompressionQuality",
        //    "TouchScreenKeyboardType", "TouchScreenKeyboard",
        //    "MovieTexture", "UnityEngineInternal",
        //    "Terrain", "Tree", "SplatPrototype",
        //    "DetailPrototype", "DetailRenderMode",
        //    "MeshSubsetCombineUtility", "AOT", "Social", "Enumerator",
        //    "SendMouseEvents", "Cursor", "Flash", "ActionScript",
        //    "OnRequestRebuild", "Ping",
        //    "ShaderVariantCollection", "SimpleJson.Reflection",
        //    "CoroutineTween", "GraphicRebuildTracker",
        //    "Advertisements", "UnityEditor", "WSA",
        //    "EventProvider", "Apple",
        //    "ClusterInput", "Motion",
        //    "UnityEngine.UI.ReflectionMethodsCache", "NativeLeakDetection",
        //    "NativeLeakDetectionMode", "WWWAudioExtensions", "UnityEngine.Experimental",
    };

}

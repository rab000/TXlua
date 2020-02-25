using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace mplExtension
{
    public abstract class LuaBase : MonoBehaviour
    {
        private mplExtension.LuaBehaviour luaBehaviour;

        public virtual void Awake()
        {
            luaBehaviour = Get<LuaBehaviour>(gameObject);
            luaBehaviour.SetLuaPath(GetLuaPath());
            luaBehaviour.SetInjection(RegistObj());
            //下面这句拿到具体lua代码段，然后cs就可以调用lua相关的awake，start了
            luaBehaviour.InitLua(AfterAwakeInitLua());
            //下面这句是把monobehaviour赋值到上面获取到的lua代码段表中，这样lua就能方便调用当前这个monobehaviour(luaBase所在的monobehaviour)了
            luaBehaviour.SetThis(GetThis());
        }

        public virtual MonoBehaviour GetThis()
        {
            return this;
        }
        public abstract string GetLuaPath();
        public virtual string GetLuaRelativePath(string file)
        {
            string filetemp = file.Replace(".", "/");
            filetemp = Application.persistentDataPath + "/res/assets/" + filetemp + ".lua.txt";
            if (File.Exists(filetemp))
            {
                return "slua.net." + file.ToLower();
            }
            else
            {
                return "slua.local." + file.ToLower();
            }
        }
        public abstract mplExtension.Injection[] RegistObj();
        public abstract object[] AfterAwakeInitLua();

        /// <summary>
        /// 从对象身上获取此组件，没有则添加
        /// </summary>
        /// <typeparam name="T">要获取的组件类型</typeparam>
        /// <param name="obj">要获取此组件的对象</param>
        /// <returns>返回此组件</returns>
        public static T Get<T>(GameObject obj) where T : Component
        {
            T t = obj.GetComponent<T>();
            if (t == null)
            {
                t = obj.AddComponent<T>();
            }
            return t;
        }
    }
}
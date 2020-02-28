/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;

namespace Tutorial
{
    public class CSCallLua : MonoBehaviour
    {
        LuaEnv luaenv = null;
        string script = @"
        a = 1
        b = 'hello world'
        c = true

        d = {
           f1 = 12, f2 = 34, 
           1, 2, 3,
           add = function(self, a, b) 
              print('d.add called')
              return a + b 
           end
        }

        function e()
            print('i am e')
        end

        function f(a, b)
            print('a', a, 'b', b)
            return 1, {f1 = 1024}
        end
        
        function ret_e()
            print('ret_e called')
            return e
        end
    ";

        public class DClass
        {
            public int f1;
            public int f2;
        }

        [CSharpCallLua]
        public interface ItfD
        {
            int f1 { get; set; }
            int f2 { get; set; }
            int add(int a, int b);
        }

        [CSharpCallLua]
        public delegate int FDelegate(int a, string b, out DClass c);

        [CSharpCallLua]
        public delegate Action GetE();

        // Use this for initialization
        void Start()
        {
            luaenv = new LuaEnv();
            luaenv.DoString(script);

            Debug.Log("引用数据:  _G.a = " + luaenv.Global.Get<int>("a"));
            Debug.Log("引用数据: _G.b = " + luaenv.Global.Get<string>("b"));
            Debug.Log("引用数据: _G.c = " + luaenv.Global.Get<bool>("c"));

            //NINFO 注意:这里lua中的d是用来描述类的
            DClass d = luaenv.Global.Get<DClass>("d");//映射到有对应字段的class，by value
            Debug.Log("lua表映射成c# 类 _G.d = {f1=" + d.f1 + ", f2=" + d.f2 + "}");

            //NINFO 这里lua中的d被映射成了Dic，注意查看下d，这里最后输出count=2，说明只映射了f1，f2，其他内容映射不了
            Dictionary<string, double> d1 = luaenv.Global.Get<Dictionary<string, double>>("d");//映射到Dictionary<string, double>，by value
            Debug.Log("lua表映射成c# Dic _G.d = {f1=" + d1["f1"] + ", f2=" + d1["f2"] + "}, d.Count=" + d1.Count);

            //NINFO 这里count=3,注意这里映射后发现只映射了1，2，3，没有处理f1，f2
            List<double> d2 = luaenv.Global.Get<List<double>>("d"); //映射到List<double>，by value
            Debug.Log("lua表映射成c# List _G.d.len = " + d2.Count);
            //for (int i = 0; i < d2.Count; i++)
            //{
            //    Debug.Log("lua表映射成c# List i:"+i+"==>"+d2[i]);
            //}

            //NINFO 接口映射，注意接口本身必须实例化才能用，就是说，实例化是在lua里做的，这很重要
            ItfD d3 = luaenv.Global.Get<ItfD>("d"); //映射到interface实例，by ref，这个要求interface加到生成列表，否则会返回null，建议用法
            d3.f2 = 1000;
            Debug.Log("lua表映射成c# 接口 _G.d = {f1=" + d3.f1 + ", f2=" + d3.f2 + "}");
            Debug.Log("lua表映射成c# 接口 _G.d:add(1, 2)=" + d3.add(1, 2));

            //NINFO 直接把d当一个表取出来，表可以通过Get方法取d里面的所有东西
            LuaTable d4 = luaenv.Global.Get<LuaTable>("d");//映射到LuaTable，by ref
            Debug.Log("lua表映直接存成c# LuaTable  _G.d = {f1=" + d4.Get<int>("f1") + ", f2=" + d4.Get<int>("f2") + "}");

            //NINFO 普通lua函数在c#调用方法，（要求delegate加到生成列表），这句暂时不懂
            Action e = luaenv.Global.Get<Action>("e");//映射到一个delgate，要求delegate加到生成列表，否则返回null，建议用法
            e();


            //NINFO 注意，这里lua函数可以多参数返回，处理方式比较诡异
            //lua 中f函数只有2个参数
            //c#的FDelegate 有3个参数，最后一个是out 类型的DClass，并且返回参数是int
            //这时后lua多返回参数与c#函数的对应关系是
            //lua第一个返回参数作为c#函数(FDelegate)的返回值，
            //第二个参数返回给DClass里的第一个变量f1，因为没有第三个参数，DClass的第二个变量被设置为0
            FDelegate f = luaenv.Global.Get<FDelegate>("f");
            DClass d_ret;
            int f_ret = f(100, "John", out d_ret);//lua的多返回值映射：从左往右映射到c#的输出参数，输出参数包括返回值，out参数，ref参数
            Debug.Log("lua多返回参数  ret.d = {f1=" + d_ret.f1 + ", f2=" + d_ret.f2 + "}, ret=" + f_ret);


            //NINFO lua中返回委托(可以认为是函数或函数引用)
            GetE ret_e = luaenv.Global.Get<GetE>("ret_e");//delegate可以返回更复杂的类型，甚至是另外一个delegate
            e = ret_e();
            e();

            //NINFO c#直接得到lua中函数
            LuaFunction d_e = luaenv.Global.Get<LuaFunction>("e");
            d_e.Call();

        }

        // Update is called once per frame
        void Update()
        {
            if (luaenv != null)
            {
                luaenv.Tick();
            }
        }

        void OnDestroy()
        {
            luaenv.Dispose();
        }
    }
}

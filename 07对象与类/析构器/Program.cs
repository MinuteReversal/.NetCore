﻿using System;

namespace 析构器
{
    class A
    {
        ~A()
        {
            System.Diagnostics.Trace.WriteLine("对象销毁了");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new A();
        }
    }
}

/*
*用编程的方式启动记事本程序。
 */
using System;
using System.Diagnostics;

namespace 启动记事本
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("notepad");
        }
    }
}

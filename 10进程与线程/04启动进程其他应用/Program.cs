using System;
using System.Diagnostics;

namespace _01任务管理器
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = Process.Start("notepad");
            Process process = new Process();
            process.StartInfo.FileName = "notepad";
        }
    }
}
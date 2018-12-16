using System;
using System.Diagnostics;
namespace _02停止进程
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process1 = new Process();
            process1.StartInfo.FileName = "notepad";
            process1.Start();
            //Process process2 = Process.Start("notepad");

            process1.WaitForInputIdle();
            process1.CloseMainWindow();
            //process2.Kill();
        }
    }
}

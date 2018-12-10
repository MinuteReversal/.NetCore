using System;
using System.Diagnostics;

namespace _04显示当前进程
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = Process.GetProcesses();
            Console.WriteLine("id\t名称\t窗口名称");
            foreach (var process in all)
            {
                Console.WriteLine($"{process.Id}\t{process.ProcessName}\t{process.MainWindowTitle}");
            }
        }
    }
}

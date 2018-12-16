using System;
using System.Threading;

namespace 挂起线程
{
    class Program
    {
        static void ThreadProc()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc {i}");
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(ThreadProc);
            thread.Start();
            Thread.Sleep(2);
            thread.Suspend();
        }
    }
}

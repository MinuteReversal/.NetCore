using System;
using System.Threading;
namespace 启动一个线程
{
    //https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread?view=netframework-4.7.2
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("thead id:{0}", Thread.CurrentThread.ManagedThreadId);
            new Thread(FnThread1).Start();
        }

        static void FnThread1()
        {
            Console.WriteLine("Thread{0}:{1},Priority{2}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.ThreadState,
                Thread.CurrentThread.Priority
            );
        }
    }
}

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
            for (var i = 0; i < 10; i++)
            {
                new Thread(FnThread1).Start(i);
            }
        }

        static void FnThread1(object index)
        {
            Console.WriteLine("index:{0}Thread{1}:{2},Priority{3}",
                (int)index,
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.ThreadState,
                Thread.CurrentThread.Priority
            );
        }
    }
}

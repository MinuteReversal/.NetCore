using System;
using System.Threading;
namespace 中止线程
{
    class Program
    {
        static void ThreadProc()
        {
            try
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1);
                }
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }

        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(ThreadProc);
            thread.Start();

            Thread.Sleep(2);
            thread.Abort();
        }
    }
}

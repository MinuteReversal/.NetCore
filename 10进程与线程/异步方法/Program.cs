/**
* https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1.result?view=netframework-4.8
*/
using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步方法
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Fn1();
            await Fn2(2);
            int fn3r = await Fn3();
            Console.Write($"Fn{fn3r}");
            int fn4r = await Fn4(4);
            Console.Write($"Fn{fn4r}");
            Console.ReadKey();
        }

        static Task Fn1()
        {
            return Task.Run(() =>
            {
                Console.Write("Fn1");
            });
        }

        static Task Fn2(int x)
        {
            return Task.Run(() =>
            {
                Console.Write($"Fn{x}");
            });
        }

        static Task<int> Fn3()
        {
            return Task.Run(() => 3);
        }

        static Task<int> Fn4(int x)
        {
            return Task.Run(() => x);
        }
    }
}

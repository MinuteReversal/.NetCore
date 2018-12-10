using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        public async static void Test()
        {
            await Fn1();
            await Fn2(2);
            Console.WriteLine(await Fn3());
            Console.WriteLine(await Fn4(4));
        }

        public static Task Fn1()
        {
            Console.WriteLine("Fn1 excute");
            Thread.Sleep(1000);
            return Task.FromResult<object>(null);
        }

        public static Task Fn2(int i)
        {
            Console.WriteLine("Fn2 excute");
            Thread.Sleep(1000);
            return Task.FromResult<object>(null);
        }

        public static Task<int> Fn3()
        {
            Console.WriteLine("Fn3 excute");
            Thread.Sleep(1000);
            return Task.FromResult(3);
        }


        public static Task<int> Fn4(int i)
        {
            Console.WriteLine("Fn4 excute");
            Thread.Sleep(1000);
            return Task.FromResult(i);
        }
    }
}

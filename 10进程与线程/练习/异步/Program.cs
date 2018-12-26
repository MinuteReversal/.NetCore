using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();//调用异步方法和调用普通方法没有区别
        }

        //async是异步的意思，异步方法用于简化回调方法。回调方法嵌套层级深不容易维护，异步方法是顺序流程执行所以比较简单。
        public async static void Test()
        {
            await Fn1();//awati是等待方法返回
            await Fn2(2);//awati是等待方法返回
            Console.WriteLine(await Fn3());//awati是等待方法返回
            Console.WriteLine(await Fn4(4));//awati是等待方法返回            
        }

        //无参数无返回的异步方法，其实是有返回的，返回内容是null，如果要使用无参数无返回的异步方法建议使用线程
        public static Task Fn1()
        {
            Thread.Sleep(1000);//暂停此线程1秒
            Console.WriteLine("Fn1 excute");
            Thread.Sleep(1000);
            return Task.FromResult<object>(null);
        }

        //有参数数无返回的异步方法，其实是有返回的，返回内容是null，如果要使用无参数无返回的异步方法建议使用有参数线程
        public static Task Fn2(int i)
        {
            Thread.Sleep(1000);//暂停此线程1秒
            Console.WriteLine("Fn2 excute");
            Thread.Sleep(1000);
            return Task.FromResult<object>(null);
        }

        //无参数，有返回值的异步方法，返回内容是整数数字
        public static Task<int> Fn3()
        {
            Thread.Sleep(1000);//暂停此线程1秒
            Console.WriteLine("Fn3 excute");
            Thread.Sleep(1000);
            return Task.FromResult(3);
        }

        //有参数，有返回值的异步方法，返回内容是整数数字
        public static Task<int> Fn4(int i)
        {
            Thread.Sleep(1000);//暂停此线程1秒
            Console.WriteLine("Fn4 excute");
            Thread.Sleep(1000);
            return Task.FromResult(i);
        }
    }
}

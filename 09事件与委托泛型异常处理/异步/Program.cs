using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步
{
    class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await Delay();
        }

        static Task Delay()
        {
            return Task.Run(() => { });
        }
    }
}

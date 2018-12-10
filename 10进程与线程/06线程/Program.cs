using System;
using System.Threading;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Thread.Sleep(1000);
            Console.WriteLine("world");
        }
    }
}

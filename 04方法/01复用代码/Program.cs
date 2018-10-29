using System;

namespace _01复用代码
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for (var i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"1~100的和是{sum}");
        }
    }
}

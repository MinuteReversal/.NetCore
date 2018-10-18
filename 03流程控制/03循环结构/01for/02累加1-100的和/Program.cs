using System;

namespace _01累加1_100的和
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            for (var i = 0; i <= 100; ++i)
            {
                total += i;
            }
            Console.WriteLine($"1-100的和是{total}");
        }
    }
}

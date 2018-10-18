using System;

namespace _02while计算1_100的和
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            var i = 0;
            while (i < 100)
            {
                i = i + 1;
                total += i;
            }
            Console.WriteLine($"1~100的和是{total}");
        }
    }
}

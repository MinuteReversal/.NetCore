/*
*计算1-100偶数的和
*/
using System;

namespace 计算1_100偶数的和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"1~100的偶数和是{sum}");
        }
    }
}

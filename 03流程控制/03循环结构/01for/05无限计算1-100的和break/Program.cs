using System;

namespace _05无限计算1_100的和break
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 0;
            for (; ; )
            {
                ++i;
                total += i;
                if (i == 100) break;
            }
            Console.WriteLine($"1 + 2 + ... 100 total is {total}");
        }
    }
}

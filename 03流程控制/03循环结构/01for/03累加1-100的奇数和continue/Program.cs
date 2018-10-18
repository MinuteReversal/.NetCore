using System;

namespace _03累加1_100的奇数和continue
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            for (var i = 0; i < 100; ++i)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                total += i;
            }
            Console.WriteLine($"奇数和是{total}");
        }
    }
}

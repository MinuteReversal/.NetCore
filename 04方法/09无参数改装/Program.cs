using System;

namespace _09无参数改装
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1~100=${sum()}");
        }

        static int sum()
        {
            var total = 0;
            for (var i = 0; i <= 100; i++)
            {
                total += i;
            }
            return total;
        }
    }
}

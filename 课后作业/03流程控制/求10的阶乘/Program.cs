using System;

namespace 求10的阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.Write($"{n}!={factorial}");
        }
    }
}

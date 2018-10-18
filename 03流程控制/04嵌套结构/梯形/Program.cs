using System;

namespace 梯形
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - i - 1; j++) Console.Write(" ");
                for (j = 0; j < (i + 3) * 2 + 1; j++) Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}

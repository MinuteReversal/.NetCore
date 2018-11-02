using System;

namespace 二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] scores = {
                //语文，数学
                { 1, 2 },
                { 3, 4 },
                { 5, 6}
            };

            Console.WriteLine($"{scores[0, 0]},{scores[0, 1]}");
            Console.WriteLine($"{scores[1, 0]},{scores[1, 1]}");
            Console.WriteLine($"{scores[2, 0]},{scores[2, 1]}");
        }
    }
}

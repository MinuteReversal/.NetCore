using System;

namespace _99
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j < 10; j++)
                {
                    Console.Write($"{i}x{j}={i * j}\t");
                }
                Console.Write("\n");
            }
        }
    }
}

/*
*输出一个三角型的99乘法表
 */
using System;

namespace 三角型的99乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write($"{i}x{j}={i * j}\t");
                }
                Console.Write("\n");
            }
        }
    }
}

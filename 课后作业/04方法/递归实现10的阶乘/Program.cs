/*
*递归实现10的阶乘
 */
using System;

namespace 递归实现10的阶乘
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Fn(10));
        }

        static int Fn(int end)
        {
            if (end == 1) return end;
            return end * Fn(end - 1);
        }
    }
}
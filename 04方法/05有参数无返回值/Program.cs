
using System;

namespace _02有参数无返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            Fn2(999);
        }

        static void Fn2(int a)//int a=999;
        {
            Console.WriteLine($"传入的值是{a}");
        }
    }
}

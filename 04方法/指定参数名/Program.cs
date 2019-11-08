using System;

namespace 指定参数名
{
    class Program
    {
        static void Main(string[] args)
        {
            add(b: 5, a: 6);
        }

        static void add(int a, int b)
        {
            Console.WriteLine($"a:{a},b:{b}");
        }
    }
}

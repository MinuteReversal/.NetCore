using System;

namespace _02语句块
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            {
                int i = 1;
                i += 2;
                i *= 2;
                Console.WriteLine("the value of i is {0}{1}", i, a);
            }
            Console.WriteLine(i);
        }
    }
}

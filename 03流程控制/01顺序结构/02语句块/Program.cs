using System;

namespace _02语句块
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i = 1;
                i += 2;
                i *= 2;
                Console.WriteLine("the value of i is {0}", i);
            }
        }
    }
}

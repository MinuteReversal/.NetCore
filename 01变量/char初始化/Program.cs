using System;

namespace char初始化
{
    class Program
    {
        static void Main(string[] args)
        {

            char c1 = 'A';
            char c2 = '\x0041';
            char c3 = (char)65;
            char c4 = '\u0041';

            Console.WriteLine($"{c1},{c2},{c3},{c4}");

        }
    }
}

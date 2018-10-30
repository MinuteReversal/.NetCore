using System;

namespace _01字符与ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = (char)97;
            char c2 = (char)65;
            int i1 = (int)c1;
            int i2 = (int)c2;
            Console.WriteLine($"{c1}{c2}{i1}{i2}");
        }
    }
}

using System;

namespace _01字符与ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char cx1 = 'X';
            char cx2 = '\x0058';
            char cx3 = (char)88;
            char cx4 = '\u0058';

            Console.WriteLine($"{cx1},{cx2},{cx3},{cx4}");

            char c1 = (char)97;
            char c2 = (char)65;
            int i1 = (int)c1;
            int i2 = (int)c2;
            Console.WriteLine($"{c1}{c2}{i1}{i2}");
        }
    }
}

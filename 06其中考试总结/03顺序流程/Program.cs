using System;

namespace _03顺序流程
{
    class Program
    {
        static void Main(string[] args)
        {
            var i1 = 0;
            var i2 = 0;
            var i3 = 0;
            var i4 = 0;

            Console.WriteLine(i1++);
            Console.WriteLine(++i2);
            Console.WriteLine(i3--);
            Console.WriteLine(--i4);
        }
    }
}

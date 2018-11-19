using System;

namespace _04装箱与拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object a = i;
            int i2 = 666;
            a = i2;
            Console.WriteLine(i);
            Console.WriteLine(a);
        }
    }
}

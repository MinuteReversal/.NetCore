using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = byte.MaxValue;
            byte b2 = byte.MaxValue;

            Console.WriteLine(Convert.ToString(b1, 2));
            Console.WriteLine(Convert.ToString(b2, 2));

            b1 = (byte)(b1 >> 1);
            b2 = (byte)(b2 << 1);

            Console.WriteLine(Convert.ToString(b1, 2));
            Console.WriteLine(Convert.ToString(b2, 2));
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}

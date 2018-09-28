using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = byte.MaxValue;
            Console.WriteLine(Convert.ToString(b1, 2));
            b1++;
            Console.WriteLine(Convert.ToString(b1, 2));

            byte b2 = byte.MinValue;
            Console.WriteLine(Convert.ToString(b2, 2));
            b2--;
            Console.WriteLine(Convert.ToString(b2, 2));
        }
    }
}

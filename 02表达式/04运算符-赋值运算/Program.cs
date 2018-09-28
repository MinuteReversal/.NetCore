using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            int i1 = 28 + 9 * 3;

            i = i1 = 100;

            Console.WriteLine(i);
            Console.WriteLine(i1);


            int i2 = 1;
            i2 += 1; //i2=i2+1;

            int i3 = 1;
            i3 -= 2; //i3=i3-2;

            int i4 = 1;
            i4 *= 3; //i4=i4*3;

            double i5 = 1;
            i5 /= 4; //i4=i4*4;
        }
    }
}

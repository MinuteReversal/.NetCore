using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            ++a;
            c += ++b;
            {
                int a1 = 4, c1 = 0;
                c1 = b * 3;
                a1 += c1;
                Console.Write("first:{0},{1},{2}\n", a1, b, c1);
                b += a1 + c1;
                Console.Write("second:{0},{1},{2}\n", a1, b, c1);
            }
            Console.Write("third:{0},{1},{2}\n", a, b, c);
        }
    }
}

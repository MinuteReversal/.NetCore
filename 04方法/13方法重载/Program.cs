using System;

namespace 方法重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(0xFF, 99));
            Console.WriteLine(add(3.14d, 5.6d));
            Console.WriteLine(add(3.14f, 5.6f));
        }

        static int add(int x, int y)
        {
            return x + y;
        }

        static double add(double x, double y)
        {
            return x + y;
        }

        static float add(float x, float y)
        {
            return x + y;
        }
    }
}

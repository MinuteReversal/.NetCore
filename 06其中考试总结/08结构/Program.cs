using System;

namespace _08结构
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Point p;
            p.x = 100;
            p.y = 100;
            Console.WriteLine($"x:{p.x},y:{p.y}");
        }
    }
}

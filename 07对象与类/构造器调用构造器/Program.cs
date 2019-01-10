using System;

namespace 构造器调用构造器
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { X = 10; Y = 20; }

        public Point(bool print) : this()
        {
            if (print)
            {
                Print();
            }
        }

        public Point(int x, int y) { X = x; Y = y; }

        public void Print()
        {
            Console.WriteLine($"x:{X},y:{Y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.Print();
            Point p2 = new Point(true);
            Point p3 = new Point(100, 200);
            p3.Print();
        }
    }
}

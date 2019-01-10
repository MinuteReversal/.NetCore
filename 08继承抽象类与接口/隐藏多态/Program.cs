using System;

namespace 隐藏多态
{

    class A
    {
        public int X { get; set; }
    }

    class B : A
    {
        public new int X { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.X = 10;
            B b = (B)a;
            b.X = 100;

            Console.WriteLine($"a.X:{a.X},b.X：{b.X}");
        }
    }
}

using System;

namespace _const
{
    class A
    {
        int num { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int i = 0;
            Console.WriteLine(i);
            const A a = new A();
            Console.WriteLine(a.num);
            a.num = 100;
            Console.WriteLine(a.num);
        }
    }
}

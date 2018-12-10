using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Action f1 = Fn1;
            Action<int> f2 = Fn2;
            Func<int> f3 = Fn3;
            Func<int, int> f4 = Fn4;

            f1();
            f2(2);
            Console.WriteLine(f3());
            Console.WriteLine(f4(4));
        }

        static void Fn1()
        {
            Console.WriteLine("call Fn1");
        }

        static void Fn2(int i)
        {
            Console.WriteLine($"call Fn2 i:{i}");
        }

        static int Fn3()
        {
            return 1024;
        }

        static int Fn4(int i)
        {
            return i;
        }
    }
}

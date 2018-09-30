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
        }

        static void Fn1()
        {

        }

        static void Fn2(int i)
        {

        }

        static int Fn3()
        {
            return 0;
        }

        static int Fn4(int i)
        {
            return 0;
        }
    }
}

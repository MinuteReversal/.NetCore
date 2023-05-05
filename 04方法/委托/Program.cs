using System;

namespace app
{
    class Program
    {
        delegate void DFn1();
        delegate void DFn2(int i);
        delegate int DFn3();
        delegate int DFn4(int i);
        static void Main(string[] args)
        {
            /*
            *以下为直接调用方法
             */
            Fn1();
            Fn2(2);
            Console.WriteLine(Fn3());
            Console.WriteLine(Fn4(4));

            /*
            * 给引用类型变量赋值
            */
            DFn1 fn1 = Fn1;
            DFn2 fn2 = Fn2;
            DFn3 fn3 = Fn3;
            DFn4 fn4 = Fn4;

            /*
            * 以下为委托调用方法
            */
            fn1();
            fn2(2);
            Console.WriteLine(fn3());
            Console.WriteLine(fn4(4));
        }

        static void Fn1()
        {
            Console.WriteLine($"Fn1");
        }

        static void Fn2(int i)
        {
            Console.WriteLine($"Fn{i}");
        }

        static int Fn3()
        {
            return 3;
        }

        static int Fn4(int i=0,int j=0)
        {
            return i;
        }
    }
}

/*
1、设计四种方法：有参有返回...
2、设计四个委托分别指向这四个方法
3、调用这四个委托
 */
using System;

namespace app
{
    class Program
    {
        delegate void DFn1();     //无参数无返回值委托定义
        delegate void DFn2(int i);//有参数无返回值委托定义
        delegate int DFn3();      //无参数有返回值委托定义
        delegate int DFn4(int i); //有参数有返回值委托定义
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
            DFn1 fn1 = Fn1;//定义委托类型DFN1的变量fn1初始值为Fn1方法的名字
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

        static int Fn4(int i)
        {
            return i;
        }
    }
}

using System;

namespace _01方法类型4种
{

    class Program
    {
        static void Main(string[] args)
        {

            Fn1();
            Fn2(2);
            Console.WriteLine(Fn3());
            Console.WriteLine(Fn4(4));
        }

        public static void Fn1()
        {
            Console.WriteLine("hello");//无参无返
        }

        public static void Fn2(int i)
        {
            Console.WriteLine(i);//有参无返
        }

        public static int Fn3()
        {
            return 3;//无参有返
        }

        public static int Fn4(int i)
        {
            return i;//有参有返
        }
    }
}

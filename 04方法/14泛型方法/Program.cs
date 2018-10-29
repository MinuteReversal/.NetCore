using System;

namespace _14泛型方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(showType(1));
            Console.WriteLine(showType(1f));
            Console.WriteLine(showType(2m));
            Console.WriteLine(showType(2d));
            Console.WriteLine(showType(2u));
            Console.WriteLine(showType(true));
            Console.WriteLine(showType("hello"));
            Console.WriteLine(showType('a'));
        }

        static string showType<T>(T x)
        {
            return x.GetType().ToString();
        }
    }
}

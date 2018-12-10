using System;

namespace _04lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action Fn1 = () => { Console.WriteLine("Fn1"); };
            Action<int> Fn2 = (i) => { Console.WriteLine(i); };
            Func<int> Fn3 = () => { return 3; };
            Func<int, int> Fn4 = (i) => { return i; };

            Fn1();
            Fn2(2);
            Console.WriteLine(Fn3());
            Console.WriteLine(Fn4(4));
        }
    }
}

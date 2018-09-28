using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var exp = (1 + 3 == 0 && true) + "888";

            Console.WriteLine(exp.GetType());
            Console.WriteLine(exp);
        }
    }
}

using System;

namespace TestDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 == 1.0);
            Console.WriteLine(0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m == 1);
        }
    }
}

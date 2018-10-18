using System;

namespace switch作业
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            switch (a)
            {
                case 100:
                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("here is b block");
                            Console.WriteLine("a's value is {0},b's value is {1}", a, b);
                            break;
                    }
                    Console.WriteLine("here is a block");
                    break;
            }
            Console.WriteLine("a's value is {0}", a);
            Console.WriteLine("b's value is {0}", b);
        }
    }
}

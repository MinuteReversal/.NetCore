/*
            int a = 100;
            int b = 200;
            if (a == 100)
            {
                if (b == 200)
                {
                    Console.WriteLine("a 的值是 100，且 b 的值是 200");
                }
            }
            Console.WriteLine("a 的准确值是 {0}", a);
            Console.WriteLine("b 的准确值是 {0}", b);
 */
using System;

namespace if嵌套改为iswitch嵌套
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
                    Console.WriteLine("这是外部 switch 的一部分");
                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("这是内部 switch 的一部分");
                            break;
                    }
                    break;
            }
            Console.WriteLine("a 的准确值是 {0}", a);
            Console.WriteLine("b 的准确值是 {0}", b);
        }
    }
}

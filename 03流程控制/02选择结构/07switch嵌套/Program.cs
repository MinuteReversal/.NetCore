using System;

namespace _07switch嵌套
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

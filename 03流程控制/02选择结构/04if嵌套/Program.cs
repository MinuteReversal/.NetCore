using System;

namespace _04if嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 局部变量定义 */
            int a = 100;
            int b = 200;

            /* 检查布尔条件 */
            if (a == 100)
            {
                /* 如果条件为真，则检查下面的条件 */
                if (b == 200)
                {
                    /* 如果条件为真，则输出下面的语句 */
                    Console.WriteLine("a 的值是 100，且 b 的值是 200");
                }
            }
            Console.WriteLine("a 的准确值是 {0}", a);
            Console.WriteLine("b 的准确值是 {0}", b);
        }
    }
}

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, t1 = 0, t2 = 1, nextTerm;

            Console.Write("输出几项: ");
            n = int.Parse(Console.ReadLine());//获取用户输入

            // 显示前两项
            Console.Write("斐波那契数列: ");

            for (i = 1; i <= n; ++i)
            {
                Console.Write("{0}, ", t1);
                nextTerm = t1 + t2;
                t1 = t2;
                t2 = nextTerm;
            }
        }
    }
}

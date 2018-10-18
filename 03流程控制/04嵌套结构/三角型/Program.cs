using System;

namespace 三角型
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("请输入三角型的底边*数");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)        //共n行
            {
                for (j = 0; j < i; j++)                 //前面的空格
                    Console.Write(" ");
                for (j = 0; j < 2 * (n - i) - 1; j++)   //输出一行上的“*”
                    Console.Write("*");
                Console.Write("\n");                    //一行结束，换行
            }
        }
    }
}
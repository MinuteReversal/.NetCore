using System;

namespace _02有参数无返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            sum(4, 59);
            int a = 13;
            sum(a, 60);
            int b = 37;
            int c = 88;
            sum(b, c);
        }

        static void sum(int x, int y)//int a=999;string word="hello word";
        {
            var total = 0;
            for (var i = x; i <= y; i++)
            {
                total += i;
            }

            Console.WriteLine($"{x}~{y}之间的整数和为{total}");
        }
    }
}

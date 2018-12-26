using System;

namespace 勾股数
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, count = 0;
            Console.Write("100以内的勾股数有：\n");
            Console.Write("a\tb\tc       a\tb\tc       a\tb\tc       a\tb\tc\n");
            /*求100以内勾股数*/
            for (a = 1; a <= 100; a++)
                for (b = a + 1; b <= 100; b++)
                {
                    c = (int)Math.Sqrt(a * a + b * b);  /*求c值*/
                    if (c * c == a * a + b * b && a + b > c && a + c > b && b + c > a && c <= 100)  /*判断c的平方是否等于a2+b2*/
                    {
                        Console.Write("{0}\t{1}\t{2}\t", a, b, c);
                        count++;
                        if (count % 4 == 0)  /*每输出4组解就换行*/
                            Console.Write("\n");
                    }
                }

            Console.Write("\n");
        }
    }
}

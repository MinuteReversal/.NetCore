using System;

namespace 两人骰子
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1, d2, c1, c2, i, j;

            c1 = c2 = 0;
            var rand = new Random();//实例化随机数对象
            rand.Next(1, 100);//随机1-100
            for (i = 1; i <= 100; i++)
            {
                /*模拟游戏过程*/
                d1 = d2 = 0;
                for (j = 1; j <= 6; j++)
                {
                    /*两人轮流郑骰子*/
                    /*随机1-100 */
                    d1 = d1 + rand.Next(1, 100) + 1;
                    d2 = d2 + rand.Next(1, 100) + 1;
                }
                if (d1 > d2)
                    c1++; /*累加获胜盘数*/
                else if (d1 < d2)
                    c2++;
            }
            if (c1 > c2) /*输出最终获胜者信息*/
                Console.Write("\n The first win.\n");
            else if (c1 < c2)
                Console.Write("\nThe second win.\n");
            else
                Console.Write("They tie.\n");
        }
    }
}

﻿using System;

namespace 菱形
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, i;                              /*i为行数,j为每行中的项数*/
            Console.Write("（n为奇数）输入图案高度n:\n");
            n = int.Parse(Console.ReadLine());
            if (n <= 0 || n % 2 == 0)
                /*判断n输入正误*/
                Console.Write("输入错误！");
            else
            {
                for (i = 1; i <= n / 2 + 1; i++)
                /*打印上三角，（包括中间行）*/
                {
                    for (j = 1; j <= n / 2 + i; j++)
                    {
                        if (j >= n / 2 - i + 2) Console.Write(" *");
                        else Console.Write("  ");
                    }
                    Console.Write("\n");
                }
                for (i = n / 2; i >= 1; i--)
                /*打印下三角，（不包括中间行）*/
                {
                    /*将i改为倒序，这样就不必再次考虑每行中项的打印，下个for循环可以直接复制上三角部分*/
                    for (j = 1; j <= n / 2 + i; j++)         /*这个for循环与上三角一致 */
                        if (j >= n / 2 - i + 2)
                            Console.Write(" *");
                        else Console.Write("  "); Console.Write("\n");
                }
            }
        }
    }
}

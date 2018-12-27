/*
*三目表达式
*int gender = 0;
*Console.WriteLine(gender == 0 ? "女" : "男");
*Console.WriteLine(gender != 0 ? "女" : "男");
 */
using System;

namespace 三目改if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int gender = 0;
            if (gender == 0)
            {
                Console.Write("女");
            }
            else
            {
                Console.Write("男");
            }
        }
    }
}

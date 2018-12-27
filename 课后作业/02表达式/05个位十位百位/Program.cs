/*
*获取365的个位数，十位数，百位数
 */
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 365;
            Console.WriteLine(365 % 10);
            Console.WriteLine(365 / 10 % 10);
            Console.WriteLine(365 / 100 % 10);
        }
    }
}

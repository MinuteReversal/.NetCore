/*
计算输入的年份是否为闰年
能被4整除且不能被100整除的为闰年。如2004年就是闰年，1900年不是闰年。
 */
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份");
            int year = Convert.ToInt32(Console.ReadLine());//year=200;
            Console.WriteLine("{0}{1}闰年", year, (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? "是" : "不是");
        }
    }
}

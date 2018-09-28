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

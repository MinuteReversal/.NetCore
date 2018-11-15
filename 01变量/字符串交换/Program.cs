using System;

namespace 字符串交换
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "绿茶";
            var b = "红荼";
            Console.WriteLine($"交换前为：{a} {b}");
            var c = a;
            a=b;
            b=c;
            Console.WriteLine($"交换后为：{a} {b}");
        }
    }
}

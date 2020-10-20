using System;

namespace string字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "AAAA";
            Console.WriteLine((int)s[0]);//输出第一个成员十进制输出
            Console.WriteLine(((int)s[1]).ToString("x"));//输出第二个成员16进制输出
            Console.WriteLine((s[2]));//输出第三个成员

            string s1 = "hello world";
            string result = s1.Substring(6, 5);
            Console.WriteLine(result);
        }
    }
}

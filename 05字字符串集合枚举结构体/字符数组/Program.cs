using System;

namespace 字符数组
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cs1 = { 'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' };
            Console.WriteLine(cs1);

            string s1 = new string(cs1);
            Console.WriteLine(s1);

        }
    }
}

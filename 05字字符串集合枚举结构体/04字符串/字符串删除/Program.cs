using System;

namespace 字符串删除
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";
            string s1 = s.Remove(8);
            Console.WriteLine(s1);

            Console.WriteLine(s.Substring(3, 5));
        }
    }
}

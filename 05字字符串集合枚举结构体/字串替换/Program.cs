using System;

namespace 字串替换
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello World!";
            string s2 = s1.Replace('o', 'x');
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

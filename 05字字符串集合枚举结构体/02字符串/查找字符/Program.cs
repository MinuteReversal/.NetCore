using System;

namespace 查找字符
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";
            Console.WriteLine(s.IndexOf('W'));
            Console.WriteLine(s.IndexOf("ld"));
        }
    }
}

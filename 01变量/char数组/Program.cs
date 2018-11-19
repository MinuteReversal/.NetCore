using System;

namespace char数组
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[4];
            chars[0] = 'A';
            chars[1] = '\x0041';
            chars[2] = (char)65;
            chars[3] = '\u0041';

            string s = new string(chars);
            Console.WriteLine(s);
        }
    }
}

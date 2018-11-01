using System;

namespace 字串拆分操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello wrold";

            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);

            for (var i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            string s2 = " hello ";
            string s3 = s2.Trim();
            Console.WriteLine(s3);
        }
    }
}

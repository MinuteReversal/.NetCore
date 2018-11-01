using System;
using System.Text;

namespace 字串拼接操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            var s1 = "world";

            string s3 = s + s1;
            string s4 = string.Concat(s, s1);
            string s5 = string.Format("{0}{1}", s, s1);
            string s6 = $"{s}{s1}";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(s);
            stringBuilder.Append(s1);
            string s7 = stringBuilder.ToString();

            Console.WriteLine(s3);
            Console.WriteLine(s4);


        }
    }
}

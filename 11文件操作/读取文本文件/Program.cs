using System;
using System.IO;

namespace 读取文本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText("1.txt");
            string l1 = sr.ReadLine();
            string content = sr.ReadToEnd();
            Console.WriteLine(l1);
            Console.WriteLine(content);
            sr.Close();
        }
    }
}

using System;
using System.IO;

namespace _02创建文件
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter f = File.CreateText("1.txt");
            f.Write("hello world");
            f.Close();
        }
    }
}

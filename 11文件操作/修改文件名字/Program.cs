using System;
using System.IO;
namespace 修改文件名字
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = File.CreateText("1.txt");
            sw.WriteLine("hello");
            sw.Close();
            File.Move("1.txt", "2.txt");
            System.Threading.Thread.Sleep(2000);
            File.Delete("2.txt");
        }
    }
}

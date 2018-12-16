using System;
using System.IO;

namespace 列出文件夹
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========文件夹==========");
            string[] directories = Directory.GetDirectories(".");//当前路径
            foreach (string d in directories)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("=========文件============");
            string[] fileNames = Directory.GetFiles(".");
            for (int i = 0; i < fileNames.Length; i++)
            {
                Console.WriteLine(fileNames[i]);
            }
        }
    }
}

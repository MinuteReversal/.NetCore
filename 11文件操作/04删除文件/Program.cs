using System;
using System.IO;

namespace _04删除文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "1.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }
    }
}

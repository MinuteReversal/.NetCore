using System;
using System.IO;

namespace _03修改文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "";
            string fileName = "1.txt";
            if (File.Exists(fileName))
            {
                content = File.ReadAllText(fileName);//读取
            }

            content += $"{DateTime.Now.ToString()}\n";
            File.WriteAllText(fileName, content);//写入
        }
    }
}

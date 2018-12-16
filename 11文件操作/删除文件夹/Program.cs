using System;
using System.IO;

namespace 删除文件夹
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("01"))
            {
                Directory.Delete("01");
            }
        }
    }
}

using System;
using System.IO;

namespace 改名文件夹
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Move("01", "02");
        }
    }
}

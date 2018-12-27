/*
*编写一个程序，让程序创建一个名字为AAA的文件夹。
 */
using System;
using System.IO;

namespace AAA文件夹
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("AAA");
        }
    }
}

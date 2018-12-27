/*
编写一个程序，让程序创建一个文本文件，并向其中输入内容如下。
吃葡萄不吐葡萄皮
不吃葡萄倒吐葡萄皮
 */
using System;
using System.IO;

namespace 文本文件里写内容
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("1.txt", "吃葡萄不吐葡萄皮\n不吃葡萄倒吐葡萄皮");
        }
    }
}

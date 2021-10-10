using System;
using System.Text;

namespace UTF8Find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var input = "";
            do
            {
                Console.WriteLine("input word");//请输入汉字
                input = Console.ReadLine();//请在终端里输入一个汉字
                Console.WriteLine($"{input}:{GetCode(input[0]).ToString("X")}");//把汉字和utf-8码输出

            } while (input != "q");//q是退出
        }
        //从字符集里查找汉字对应的utf-8码
        static int GetCode(char c)
        {
            for (var i = 0; i < 0xFFFF; i++)
            {
                if ((char)i == c)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

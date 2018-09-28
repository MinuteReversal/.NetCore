using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字");
            int i = Console.Read();
            Console.WriteLine("请按下一个按钮");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("请输入一行字");
            string s = Console.ReadLine();

            Console.WriteLine(i);
            Console.WriteLine(keyInfo);
            Console.WriteLine(s);
        }
    }
}

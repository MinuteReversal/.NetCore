using System;

namespace _02获取输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/zh-cn/dotnet/api/system.consolekey?view=netframework-4.7.2
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("press any key");
                keyInfo = Console.ReadKey(true);
                Console.Write($"{keyInfo.Key}:{(int)keyInfo.Key}");
                Console.WriteLine();
            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}

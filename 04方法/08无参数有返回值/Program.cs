using System;

namespace _08无参数有返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Fn3();
            Console.WriteLine($"Fn3 返回了{result}");
        }

        static int Fn3()
        {
            return 1024;
        }
    }
}

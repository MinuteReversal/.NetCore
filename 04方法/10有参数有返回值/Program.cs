using System;

namespace _10有参数有返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 100;

            Console.WriteLine($"{x}~{y}={Fn4(x, y)}");
        }

        static int Fn4(int a, int b)
        {
            var sum = 0;
            for (var i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}

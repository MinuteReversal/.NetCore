using System;

namespace _04随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(0, 100));
            }
        }
    }
}

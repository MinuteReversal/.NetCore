using System;

namespace 二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myarray = {
                { 1, 2 },
                { 3, 4 },
                { 5, 6}
            };

            Console.WriteLine($"{myarray[0, 0]}");
            Console.WriteLine($"{myarray[0, 1]}");
            Console.WriteLine($"{myarray[1, 0]}");
            Console.WriteLine($"{myarray[1, 1]}");
            Console.WriteLine($"{myarray[2, 0]}");
            Console.WriteLine($"{myarray[2, 1]}");
        }
    }
}

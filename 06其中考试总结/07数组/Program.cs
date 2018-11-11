using System;

namespace _07数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someNumber = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            someNumber[1] = 888;
            Console.WriteLine(someNumber[1]);
        }
    }
}

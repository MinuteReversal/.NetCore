using System;

namespace _02如何使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 61, 73, 84, 66, 99, 100 };
            int[] a2 = array;

            Console.WriteLine(array[0]);
            array[0] = 71;

            array[0] = array[1];

            Console.WriteLine(array[array.Length - 1]);
        }
    }
}

using System;

namespace _03访问每一个成员
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 61, 73, 84, 66, 99, 100 };
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;

namespace _02foreach遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 4, 3, 2, 1 };
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;

namespace _03for遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 9, 8, 7, 6, 5 };
            for (var i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            for (var i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[myArray.Length - 1 - i]);
            }
        }
    }
}

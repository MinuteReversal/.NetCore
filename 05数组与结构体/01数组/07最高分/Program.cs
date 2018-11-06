using System;

namespace _07最高分
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 61, 73, 84, 66, 99, 100 };
            int max = 0;
            for (var i = 0; i < a.Length; i++)
            {
                if (max < a[i]) max = a[i];
            }
            Console.WriteLine(max);
        }
    }
}

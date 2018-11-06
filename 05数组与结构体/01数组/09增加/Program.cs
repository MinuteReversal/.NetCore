using System;

namespace _09增加
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 61, 73, 84, 66, 99, 100 };
            int[] a1 = new int[a.Length + 1];
            for (var i = 0; i < a.Length; i++)
            {
                a1[i] = a[i];
            }
            a1[a1.Length - 1] = 88;
            Console.WriteLine(string.Join(",", a1));
        }
    }
}

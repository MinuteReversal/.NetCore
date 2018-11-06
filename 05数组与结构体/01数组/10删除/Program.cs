using System;

namespace _10删除
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 61, 73, 84, 66, 99, 100, 88 };
            int[] a1 = new int[a.Length - 1];
            for (var i = 0; i < a1.Length; i++)
            {
                a1[i] = a[i];
            }
            Console.WriteLine(string.Join(",", a1));
        }
    }
}

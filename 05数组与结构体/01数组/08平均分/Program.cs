using System;

namespace _08平均分
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 61, 73, 84, 66, 99, 100 };
            int sum = 0;
            for (var i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum / a.Length);
        }
    }
}

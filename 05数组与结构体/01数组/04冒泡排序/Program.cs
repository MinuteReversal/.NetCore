using System;

namespace _04冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 61, 73, 84, 66, 99, 100 };
            for (var j = 0; j < a.Length; j++)
            {
                for (var i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] < a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;

namespace 数组经过方法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };//引用类型（windows快捷方式)
            int[] b = a;
            Show(a);
            Show(b);
            a[2] = 88;
            a[4] = 77;
            Show(a);
            Show(b);
        }

        static void Line()
        {
            Console.WriteLine("============华丽的分割线===========");
        }

        static void Show(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

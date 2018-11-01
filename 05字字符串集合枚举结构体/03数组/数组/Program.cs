using System;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array3 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine(array1[1]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array3[1]);

            array1[0] = 8;
            array1[1] = 9;

            for (var i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            line();
            for (var i = 0; i < array2.Length; i++)
            {
                array2[i] += 1;
            }
            line();
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
        }
        static void line(){
            Console.WriteLine("================普通的分割线===============");
        }
    }
}

using System;
using System.Collections.Generic;

namespace 列表
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            line();

            list.Add(7);
            list.Add(8);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void line()
        {
            Console.WriteLine("===========================");
        }
    }
}

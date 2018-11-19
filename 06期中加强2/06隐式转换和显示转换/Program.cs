using System;

namespace _04隐式转换和显示转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //隐式转换
            float f = 3.14f;
            double db = f;

            Console.WriteLine(f);
            Console.WriteLine(db);

            //显示转换
            f = (float)db;
            int i = (int)f;
            Console.WriteLine(f);
            Console.WriteLine(i);
        }
    }
}

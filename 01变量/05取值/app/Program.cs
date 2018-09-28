using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义变量

            //值类型变量
            int i = 123;
            int i2 = 0;
            int i3 = 0;
            int i4 = 0;


            i2 = i;
            i3 = i;
            i4 = i;

            Console.WriteLine(i2);
            Console.WriteLine(i3);
            Console.WriteLine(i4);
            Console.WriteLine(i);
        }
    }
}

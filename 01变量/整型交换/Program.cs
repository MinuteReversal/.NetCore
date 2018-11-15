using System;

namespace 整型交换
{
    class Program
    {

        static void Main(string[] args)
        {
            //不使用第三个变量达到交换两个变量值的目的
            int a, b;
            Console.Write("请输入两个数字(使用空格分开)：");
            string[] inputs = Console.ReadLine().Split(" ");
            a = Convert.ToInt32(inputs[0]);
            b = Convert.ToInt32(inputs[1]);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("交换后为:{0},{1}", a, b);
        }
    }
}

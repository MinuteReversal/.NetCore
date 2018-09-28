using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义变量

            //值类型变量
            double pi = 3.14;
            int i = 123;
            int i1 = 0;
            string s = "32";
            string s2 = "";

            //转换
            //显示转换
            i = (int)pi;
            pi = (double)i;

            //隐式转换
            pi = i;


            //使用Convert转换数据

            s = Convert.ToString(i);
            i1 = Convert.ToInt32(s);


            Console.WriteLine(Convert.ToString(i, 2));
            Console.WriteLine(Convert.ToString(pi));

        }
    }
}

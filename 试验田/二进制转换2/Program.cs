using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出为二进制
            int i = int.MinValue;
            Console.WriteLine(i);
            string bs = Convert.ToString(i, 2);
            Console.WriteLine(bs);
            Console.WriteLine(bs.Length);

            //二进制转化为数字
            int i1 = Convert.ToInt32("10000000000000000000000000000000");
            Console.WriteLine(i1);

        }
    }
}

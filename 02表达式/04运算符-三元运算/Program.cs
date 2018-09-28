using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true ? "是" : "否");
            Console.WriteLine(false ? "是" : "否");


            int gender = 0;
            Console.WriteLine(gender == 0 ? "女" : "男");
            Console.WriteLine(gender != 0 ? "女" : "男");
        }
    }
}

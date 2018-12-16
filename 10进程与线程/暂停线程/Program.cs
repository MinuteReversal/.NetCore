using System;

namespace 暂停线程
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(++i);//一秒钟输出一次数字
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

/*
P175
一个线程输出1到100
另外一个线程输出100到1
 */
using System;
using System.Threading;

namespace 双线程输出
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Fn1);
            Thread t2 = new Thread(Fn2);

            t1.Start();
            t2.Start();
        }

        static void Fn1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Fn2()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

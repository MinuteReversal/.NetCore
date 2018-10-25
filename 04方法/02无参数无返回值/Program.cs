using System;

namespace _01无参数无返回值
{
    class Program
    {
        static void Main(string[] args)
        {            
            sum1to100();
            sum1to100();
            sum1to100();
        }

        static void sum1to100()
        {
            var sum = 0;
            for (var i = 1; i <= 100; i++)
            {
                sum += i ;
            }
            Console.WriteLine($"1~100的和是{sum}");            
        }

        static void aaaa()
        {
            Console.WriteLine("here is aaa");
        }

    }
}

using System;

namespace 递归转二进制
{
    class Program
    {

        ///<summary>整型转2进制字符串</summary>
        ///<param name="n">要转换的数字</param>
        ///<returns>返回二进制字符串</returns>
        ///<remarks>演示如何使用xml注释</remarks>
        static string IntToBin(int n)
        {
            string sBin = "";//显示转换，整型转字符串
            if (n == 1 || n == 0)
            {
                sBin += n;//存在隐式转换，把整型变量转化为字符串变量
            }
            else
            {
                sBin += IntToBin(n / 2) + (n % 2);//DecToBin自己调用自己（递归）
            }

            return sBin;
        }
        static void Main(string[] args)
        {
            Console.Write("请输入一个数字:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"转化为二进制为：{IntToBin(number)}");
        }
    }
}
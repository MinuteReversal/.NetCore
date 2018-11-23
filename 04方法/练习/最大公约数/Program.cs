using System;

namespace 最大公约数
{
    class Program
    {
        ///<summary>求解最大公约数</summary>
        ///<param name="n">整数</param>
        ///<param name="m">整数</param>
        ///<returns>最大公约数</returns>
        static int Division(int n, int m)
        {
            if (n < m)
                return Division(m, n); //交换n，m的值
            else if (n == m)
                return n;
            else
            {
                int temp = n;
                n = m;
                m = temp - n;
                return Division(n, m); //重复上述过程
            }
        }

        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("请输入两个数，用空格分开");
            string[] inputs = Console.ReadLine().Split(" ");//注意有空格
            n = Convert.ToInt32(inputs[0]);
            m = Convert.ToInt32(inputs[1]);
            Console.WriteLine($"{n}和{m}的最大公约数是：{Division(n, m)}");
        }
    }
}

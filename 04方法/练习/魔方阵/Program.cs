using System;

namespace 魔方阵
{
    class Program
    {

        ///<summary>魔方阵</summery>
        ///<param name="n">大小</param>
        ///<returns>无</returns>
        static void Magic(int n)
        {
            int i, j, no, num, max;
            if (n % 2 == 0)  /*n是偶数，则加1使其变为奇数*/
            {
                n = n + 1;
            }
            max = n * n;
            int[,] mtrx = new int[n, n];
            mtrx[0, n / 2] = 1;  /* 将1存入数组*/
            i = 0;  /*自然数1所在行*/
            j = n / 2;  /*自然数1所在列*/
                        /*从2开始确定每个数的存放位置*/
            for (num = 2; num <= max; num++)
            {
                i = i - 1;
                j = j + 1;
                if ((num - 1) % n == 0)  /*当前数是n的倍数*/
                {
                    i = i + 2;
                    j = j - 1;
                }
                if (i < 0)  /*当前数在第0行*/
                {
                    i = n - 1;
                }
                if (j > n - 1)  /*当前数在最后一列，即n-1列*/
                {
                    j = 0;
                }
                mtrx[i, j] = num;/*找到当前数在数组中的存放位置*/
            }
            /*打印生成的魔方阵*/
            Console.Write("生成的{0}-魔方阵为:", n);
            no = 0;
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", mtrx[i, j]);
                    no++;
                }
            }
            Console.Write("\n");
        }
        
        static void Main(string[] args)
        {
            int n;
            Console.Write("请输入n值:\n");
            n = int.Parse(Console.ReadLine());
            Magic(n);  /*调用魔方阵*/
        }
    }
}

/*
让用户输入一个0-100的数字x
x==100                  输出学霸
X>=90 &&  x<100  输出优异
X>=80   && x<90  输出不错
X>=70  && x<80    输出过得去
X>60    &&  x<70   及格
X==60 刚刚好
其他                       不及格

 */
using System;

namespace 分数评价
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入分数：");
            int x = int.Parse(Console.ReadLine());
            if (x == 100)
            {
                Console.Write("学霸");
            }
            else if (x >= 90 && x < 100)
            {
                Console.Write("优异");
            }
            else if (x >= 80 && x < 90)
            {
                Console.Write("不错");
            }
            else if (x >= 70 && x < 80)
            {
                Console.Write("过得去");
            }
            else if (x > 60 && x < 70)
            {
                Console.Write("及格");
            }
            else if (x == 60)
            {
                Console.Write("刚刚好,不多不少");
            }
            else
            {
                Console.Write("不及格");
            }
        }
    }
}

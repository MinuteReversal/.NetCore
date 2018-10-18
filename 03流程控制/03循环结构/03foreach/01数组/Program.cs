using System;

namespace _01数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个数组
            string[] somewords1 = new string[] { "大家好", "我是zhy", "今天是", "2018年10月18日" };
            string[] somewords2 = new string[3];//有几个项(成员)

            //数组使用索引访问，以0开始
            somewords2[0] = "第一项";
            somewords2[1] = "第二项";
            somewords2[3] = "第三项";

            //赋值就把数组的成员放在=的左边有点类似变量赋值
            string s = "hello";


            //取值
            string s2 = somewords1[1];
            Console.WriteLine(somewords2[2]);

            //Console.WriteLine(somewords2[3]);//索引越界
        }
    }
}

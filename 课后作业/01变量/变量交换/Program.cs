/*
    有三个变量
    string cup1="红酒";
    string cup2="雪碧";
    string cup3="";
    尝试将 cup1和cup2中的内容互换并输出
    Console.WriteLine("cup1里的是{0}",cup1);
    Console.WriteLine("cup2里的是{0}",cup2);
    Console.WriteLine("cup3里的是{0}",cup3);
 */
using System;

namespace _01变量
{
    class Program
    {
        static void Main(string[] args)
        {
            string cup1 = "红酒";
            string cup2 = "雪碧";
            string cup3 = "";

            cup3 = cup1;//杯子一的内容复制并存入给杯子三
            cup1 = cup2;//杯子二的内容复制并存入给杯子一
            cup2 = cup3;//杯子三的内容复制并存入给杯子二

            Console.WriteLine("cup1里的是{ 0}", cup1);
            Console.WriteLine("cup2里的是{ 0}", cup2);
            Console.WriteLine("cup3里的是{ 0}", cup3);
        }
    }
}

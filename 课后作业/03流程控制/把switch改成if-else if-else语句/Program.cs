/*
        static void Main(string[] args)
        {
            var fruittype = "Oranges";
            switch (fruittype)
            {
                case "Oranges":
                    Console.WriteLine("桔子1.1元");
                    break;
                case "Apples":
                    Console.WriteLine("苹果1.2元");
                    break;
                case "Bananas":
                    Console.WriteLine("香蕉1.3元");
                    break;
                default:
                    Console.WriteLine("对不起没有 " + fruittype + "水果");
                    break;
            }
            Console.WriteLine("还有其他你喜欢的吗？");
            Console.WriteLine("you choose is {0}", fruittype);
 */
using System;

namespace 把switch改成if_else_if_else语句
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruittype = "Oranges";
            if (fruittype == "Oranges")
            {
                Console.WriteLine("桔子1.1元");
            }
            else if (fruittype == "Apples")
            {
                Console.WriteLine("苹果1.2元");
            }
            else if (fruittype == "Bananas")
            {
                Console.WriteLine("香蕉1.3元");
            }
            else
            {
                Console.WriteLine("对不起没有 " + fruittype + "水果");
            }
            Console.WriteLine("还有其他你喜欢的吗？");
            Console.WriteLine("you choose is {0}", fruittype);
        }
    }
}

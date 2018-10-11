using System;

namespace _05switch语句
{
    class Program
    {
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

        }
    }
}

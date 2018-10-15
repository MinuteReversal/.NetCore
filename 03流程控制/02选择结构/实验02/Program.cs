using System;

namespace 实验02
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "a==10";
            switch (number)
            {
                case "a==10":
                    Console.WriteLine("a的值是10");
                    break;
                case "a==20":
                    Console.WriteLine("a的值是20");
                    break;
                case "a==30":
                    Console.WriteLine("a的值是30");
                    break;
                default:
                    Console.WriteLine("没有匹配项");
                    break;
            }
            Console.WriteLine("a的准确值是{0}", number);
        }
    }
}

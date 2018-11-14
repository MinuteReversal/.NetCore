using System;

namespace Question
{
    class Program
    {
        static void Main(string[] args)
        {
            var choice = "";
            do
            {
                Console.Write(
                                "请输入序号进行选择\n" +
                                "1.开始游戏\n" +
                                "2.继续游戏\n" +
                                "3.加载存档\n" +
                                "4.设置\n" +
                                "5.人员名单\n" +
                                "6.退出\n"
                            );
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Option1();
                        break;
                    case "2":
                        Option2();
                        break;
                    case "3":
                        Option3();
                        break;
                    case "4":
                        Option4();
                        break;
                    case "5":
                        Option5();
                        break;
                    default:
                        break;
                }
            } while (choice != "6");
        }

        static void Option1()
        {
            Console.WriteLine("你的选择是开始游戏");
        }

        static void Option2()
        {
            Console.WriteLine("你的选择是继续游戏");
        }

        static void Option3()
        {
            Console.WriteLine("你的选择是加载存档");
        }

        static void Option4()
        {
            Console.WriteLine("你的选择是设置");
        }

        static void Option5()
        {
            Console.WriteLine("你的选择是人员名单");
        }
    }
}

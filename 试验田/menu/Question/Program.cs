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
                Line();//华丽的分隔线
                Console.Write(
                                "请输入序号进行选择\n" +
                                "1.开始游戏\n" +
                                "2.继续游戏\n" +
                                "3.加载存档\n" +
                                "4.设置\n" +
                                "5.人员名单\n" +
                                "6.退出\n" +
                                "请输入您的选择："
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
            Console.WriteLine("游戏开始了。");
            Console.WriteLine("Good Luck");
        }

        static void Option2()
        {
            Console.WriteLine("你的选择是继续游戏");
            Console.WriteLine("加载了上次的存档，游戏继续了。");
        }

        static void Option3()
        {
            Console.WriteLine("你的选择是加载存档");
            Console.WriteLine("请选择存档：\n> 1.2018-11-14\n  2.2018-09-12");
        }

        static void Option4()
        {
            Console.WriteLine("你的选择是设置");
            Console.WriteLine("没有设计设置功能。");
        }

        static void Option5()
        {
            Console.WriteLine("你的选择是人员名单");
            Console.WriteLine("设计：反转的分针");
            Console.WriteLine("实现：反转的分针");
            Console.WriteLine("界面：反转的分针");
        }

        //画一条分隔线
        static void Line(int count = 20, char word = '*')
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write(word);
            }
            Console.Write("\n");
        }
    }
}

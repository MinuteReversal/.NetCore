using System;

namespace 随机数
{
    class Program
    {
        static void RollNumberToChar(int Number)
        {
            char[] dice = new char[] { '\u2680', '\u2681', '\u2682', '\u2683', '\u2684', '\u2685' };
            Console.WriteLine($"{dice[Number]}:{Number + 1}");
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.OutputEncoding = System.Text.Encoding.UTF8;            
            string input = "";
            while (input != "q")
            {
                Console.Write("来投个骰子\n按任意按键投。\n");
                input = Console.ReadLine();
                RollNumberToChar(random.Next(0, 6));
            }
        }
    }
}

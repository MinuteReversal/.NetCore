using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 15; i++)
            {
                Console.BackgroundColor = (ConsoleColor)i;
                Console.Write("\u2593");
                Console.ForegroundColor = (ConsoleColor)i;                
                Console.Write((char)9608);
            }
            Console.ResetColor();
        }
    }
}

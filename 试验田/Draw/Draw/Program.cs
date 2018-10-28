using System;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"top:{Console.CursorTop},left:{Console.CursorLeft}");
            Console.SetCursorPosition(1, 0);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.ResetColor();
        }
    }
}

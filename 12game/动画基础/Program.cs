using System;
using System.Drawing;
using System.Threading;
using System.Text;

namespace 动画基础
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            GameLoop();
        }

        static Point current;
        static void GameLoop()
        {            
            while (true)
            {
                MovePoint();
                Draw();
                Thread.Sleep(1000);
            }
        }

        static void MovePoint()
        {
            if (current.X < Console.WindowWidth)
            {
                current.X+=2;
            }
            else
            {
                current.X = 0;
                current.Y++;
            }


            if (current.Y > Console.WindowHeight)
            {
                current.Y = 0;
            }
        }

        static void Draw()
        {
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                for (int y = 0; y < Console.WindowHeight; y++)
                {
                    Console.SetCursorPosition(x, y);
                    if (current.X == x && current.Y == y)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}

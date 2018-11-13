using System;
using System.Text;
using System.Threading;

namespace SingleSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Single";
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(0,0);
            Console.Clear();
            while (true)
            {
                DrawBorder();
            }
        }

        static DateTime last = new DateTime();
        static int count=0;
        static void DrawBorder()
        {
            Thread.Sleep(1000);
            count++;
            for (var y = 0; y < Console.WindowHeight; y++)
            {
                var line = "";
                for (var x = 0; x < Console.WindowWidth; x++)
                {
                    if (x < count.ToString().Length && y == 0)
                    {
                        line += count.ToString()[x];
                    }
                    else
                    {
                        line += "*";
                    }
                }
                Console.SetCursorPosition(0, y);
                Console.Write(line);
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}

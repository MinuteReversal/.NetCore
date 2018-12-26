using System;
namespace SnakeGame
{
    class Border : AComponent
    {
        public Border()
        {
            //生成边框
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                for (int y = 0; y < Console.WindowHeight; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        this.shape.Add(new Cell()
                        {
                            X = x,
                            Y = y,
                            Char = '\u250c',//┌ 
                            Color = ConsoleColor.Gray,
                            BackgroundColor = ConsoleColor.Black
                        });
                    }
                    else if (x == Console.WindowWidth - 1 && y == 0)
                    {
                        this.shape.Add(new Cell()
                        {
                            X = x,
                            Y = y,
                            Char = '\u2510',//┐
                            Color = ConsoleColor.Gray,
                            BackgroundColor = ConsoleColor.Black
                        });
                    }
                    else if (x == 0 && y == Console.WindowHeight - 1)
                    {
                        this.shape.Add(new Cell()
                        {
                            X = x,
                            Y = y,
                            Char = '\u2514',//└ 
                            Color = ConsoleColor.Gray,
                            BackgroundColor = ConsoleColor.Black
                        });
                    }
                    else if (x == Console.WindowWidth - 1 && y == Console.WindowHeight - 1)
                    {
                        this.shape.Add(new Cell()
                        {
                            X = x,
                            Y = y,
                            Char = '\u2518',//┘
                            Color = ConsoleColor.Gray,
                            BackgroundColor = ConsoleColor.Black
                        });
                    }
                    else if (y == 0 || y == Console.WindowHeight - 1)
                    {
                        this.shape.Add(new Cell()
                        {
                            X = x,
                            Y = y,
                            Char = '\u2500',//─
                            Color = ConsoleColor.Gray,
                            BackgroundColor = ConsoleColor.Black
                        });
                    }
                    else if (x == 0 || x == Console.WindowWidth - 1)
                    {
                        this.shape.Add(new Cell()
                        {
                            X = x,
                            Y = y,
                            Char = '\u2502',//│
                            Color = ConsoleColor.Gray,
                            BackgroundColor = ConsoleColor.Black
                        });
                    }
                }
            }
        }

        public override void Frame() { }
    }
}
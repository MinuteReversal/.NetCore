using System;

namespace SnakeGame
{
    class Apple : AComponent
    {
        public Apple()
        {
            //随机生成苹果的位置
            Random r = new Random();
            int x = r.Next(1, Console.WindowWidth - 2);
            int y = r.Next(1, Console.WindowHeight - 2);

            this.shape.Add(new Cell
            {
                X = x,
                Y = y,
                Char = '@',
                Color = ConsoleColor.Red,
                BackgroundColor = ConsoleColor.Black
            });
        }
        public override void Frame() { }
    }
}
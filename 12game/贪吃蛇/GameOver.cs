using System;
using System.Drawing;
using System.Collections.Generic;

namespace SnakeGame
{

    struct WidthHeight
    {
        public int Width;
        public int Height;

        public WidthHeight(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }

    //游戏结束，需要写一些统计信息
    class GameOver : AComponent
    {

        public GameOver(byte score = 0)
        {
            List<string> words = new List<string>(){
                {"Game Over!"},
                {$"Your score: {score}."},
                {"Press [Enter] Restart."},
                {"Press [ESC] to Exit."}
            };

            this.shape = this.CreateShape(words);
        }

        //创建图形
        List<Cell> CreateShape(List<string> words)
        {
            var list = new List<Cell>();
            var wh = this.GetTextWidthHeight(words);
            var drawPoint = this.GetStartDrawPoint(wh);

            for (int y = 0; y < Console.WindowHeight; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    if (
                        y >= drawPoint.Y &&
                        y - drawPoint.Y < words.Count &&
                        x >= drawPoint.X &&
                        x - drawPoint.X < words[y - drawPoint.Y].Length
                    )
                    {
                        list.Add(new Cell()
                        {
                            X = x,
                            Y = y,
                            Char = words[y - drawPoint.Y][x - drawPoint.X],
                            Color = ConsoleColor.White
                        });
                    }
                }
            }
            return list;
        }

        //获取要输出的文字的高宽
        WidthHeight GetTextWidthHeight(List<string> text)
        {
            int maxWidth = 0;
            int maxHeight = 0;
            for (var y = 0; y < text.Count; y++)
            {
                for (var x = 0; x < text[y].Length; x++)
                {
                    maxWidth = Math.Max(x, maxWidth);
                }
                maxHeight = Math.Max(y, maxHeight);
            }

            return new WidthHeight(maxWidth, maxHeight);
        }

        //获取开始绘制的点
        Point GetStartDrawPoint(WidthHeight wh)
        {
            return new Point(
                (Console.WindowWidth - wh.Width) / 2,
                (Console.WindowHeight - wh.Height) / 2
            );
        }

        public override void Frame()
        {

        }
    }
}
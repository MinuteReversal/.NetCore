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
    class GameOver : ATextComponent
    {

        public GameOver(byte score = 0)
        {
            IList<string> words = new List<string>(){
                {"Game Over!"},
                {$"Your score: {score}."},
                {"Press [Enter] Restart."},
                {"Press [ESC] to Exit."}
            };

            this.shape = this.CreateShape((List<string>)words);
        }
    }
}
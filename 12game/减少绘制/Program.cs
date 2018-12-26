using System;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace 动画基础
{

    class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ConsoleColor Color { get; set; }//终端可以输出的颜色
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//输出为UTF8
            Console.CursorVisible = false;         //隐藏终端的光标
            init();
            Loop();
        }

        static Cell current = new Cell { Color = ConsoleColor.Red };//高亮点的位置
        static List<Cell> LastFrame = null;//上一帧
        static int ScreenWidth = 2;//屏幕宽度
        static int ScreenHeight = 2;//屏幕高度

        //初始化设置
        static void init()
        {
            ScreenWidth = Console.WindowWidth;
            ScreenHeight = Console.WindowHeight;
            var frame = GetEmptyFrame();
            LastFrame = frame;
            Draw(frame);
        }


        //无限循环
        static void Loop()
        {
            while (true)//循环
            {
                MovePoint();//移动点
                var currentFrame = DrawFrame();
                var difference = GetDifferenceCell(LastFrame, currentFrame);
                LastFrame = currentFrame;
                Draw(difference);
                Thread.Sleep(1);//暂停线程1000毫秒
            }
        }

        //移动点的业务逻辑
        static void MovePoint()
        {
            //当前的点没有超出屏幕宽度就一直向右边移动
            if (current.X < ScreenWidth)
            {
                current.X += 1;//向右边移动一格
            }
            else
            {
                current.X = 0;//回至最左边
                current.Y++;//当前点超出屏幕宽度则换到下一行
            }

            //如果超过屏幕的最下面
            if (current.Y > ScreenHeight)
            {
                current.Y = 0;//回到顶部
            }
        }

        static List<Cell> DrawFrame()
        {
            var cells = GetEmptyFrame();
            for (int i = 0; i < cells.Count; i++)
            {
                if (cells[i].X == current.X && cells[i].Y == current.Y)
                {
                    cells[i].Color = current.Color;
                    break;
                }
            }

            return cells;
        }

        //全黑色的帧
        static List<Cell> GetEmptyFrame()
        {
            var list = new List<Cell>();
            for (int x = 0; x < ScreenWidth; x++)
            {
                for (int y = 0; y < ScreenHeight; y++)
                {
                    list.Add(new Cell()
                    {
                        X = x,
                        Y = y,
                        Color = ConsoleColor.Black
                    });
                }
            }
            return list;
        }

        static List<Cell> GetDifferenceCell(List<Cell> m, List<Cell> n)
        {
            var list = new List<Cell>();
            for (var i = 0; i < m.Count; i++)
            {
                if (m[i].Color != n[i].Color)
                {
                    var cell = new Cell()
                    {
                        X = m[i].X,
                        Y = m[i].Y,
                        Color = n[i].Color
                    };

                    list.Add(cell);
                }
            }
            return list;
        }

        static void Draw(List<Cell> list)
        {

            foreach (var c in list)
            {
                Console.SetCursorPosition(c.X, c.Y);
                Console.BackgroundColor = c.Color;
                Console.Write(" ");//输出一个空格
            }
            Console.SetCursorPosition(0, 0);//整个终端的高宽绘制完成后把光标移动到最开始，以防止生成多余的行
        }
    }
}

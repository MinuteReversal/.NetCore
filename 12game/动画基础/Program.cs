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
            Console.OutputEncoding = Encoding.UTF8;//输出为UTF8
            Console.CursorVisible = false;         //隐藏终端的光标
            Loop();
        }

        static Point current;//高亮点的位置

        //无限循环
        static void Loop()
        {            
            while (true)//循环
            {
                MovePoint();//移动点
                Draw();//绘制
                Thread.Sleep(1);//暂停线程200毫秒
            }
        }

        //移动点的业务逻辑
        static void MovePoint()
        {
            //当前的点没有超出屏幕宽度就一直向右边移动
            if (current.X < Console.WindowWidth)
            {
                current.X+=1;//向右边移动一格
            }
            else
            {
                
                current.X = 0;//回至最左边
                current.Y++;//当前点超出屏幕宽度则换到下一行
            }

            //如果超过屏幕的最下面
            if (current.Y > Console.WindowHeight)
            {
                current.Y = 0;//回到顶部
            }
        }

        static void Draw()
        {
            //
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                for (int y = 0; y < Console.WindowHeight; y++)
                {
                    Console.SetCursorPosition(x, y);//设置绘制的位置
                    if (current.X == x && current.Y == y)//绘制的点和当前点位置相同
                    {
                        Console.BackgroundColor = ConsoleColor.Red;//用红色绘制当前的点
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;//其他情况绘制为黑色
                    }
                    Console.Write(" ");//输出一个空格
                }
            }
            Console.SetCursorPosition(0, 0);//整个终端的高宽绘制完成后把光标移动到最开始，以防止生成多余的行
        }
    }
}

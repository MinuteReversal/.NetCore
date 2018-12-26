using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeGame
{

    //按键按下的内容
    public class KeyDownEventArgs : EventArgs
    {
        public ConsoleKeyInfo KeyInfo { get; set; }
    }

    //碰撞事件内容
    public class CollisionEventArgs : EventArgs
    {
        public AComponent Target { get; set; }//目标，和谁发生了碰撞
    }

    delegate void KeyDownEventHandler(object sender, KeyDownEventArgs args);//自定义按键按下事件处理委托

    delegate void CollisionEventHandler(object sender, CollisionEventArgs args);//自定义碰撞事件处理委托

    public class Game
    {
        protected int ScreenWidth { get; set; }//屏幕宽度
        protected int ScreenHeight { get; set; }//屏幕高度


        event KeyDownEventHandler KeyDown;//按键按下事件


        event CollisionEventHandler Collision;//物体碰撞事件

        IList<IComponent> Scene = new List<IComponent>();//场景
        Queue<IComponent> AddQueue = new Queue<IComponent>();//添加队列
        Queue<IComponent> RemoveQueue = new Queue<IComponent>();//移出队列

        IList<IList<Cell>> lastFrame = null;//上一帧

        Snake Player1 = null;

        byte Score = 0;

        bool isQuit = false;
        bool isPause = false;

        //初始化设置
        public Game()
        {
            ScreenWidth = Console.WindowWidth;   //把终端的宽度保存下来
            ScreenHeight = Console.WindowHeight;//把终端的高度保存下来
            KeyDown += OnKeyDown;               //监测按钮按下
            Collision += OnCollision;           //监测碰撞
            this.Reset();                       //重置游戏
            this.Start();                       //开始游戏
        }

        //重置游戏
        public void Reset()
        {
            this.isPause = true;
            this.Clear();//清除终端上的字
            this.Player1 = new Snake();
            this.Scene.Clear();//清除场景上的元件
            this.Score = 0;
            this.Scene.Add(new Border());//添加边框
            this.Scene.Add(this.Player1);//添加玩家1
            this.Scene.Add(new Apple());//添加苹果
            this.isPause = false;
        }

        //碰撞检测处理
        private void OnCollision(object sender, CollisionEventArgs args)
        {
            if (sender is Snake && args.Target is Apple)
            {
                this.RemoveQueue.Enqueue(args.Target);//被吃掉的苹果添加到删除队列
                ((Snake)sender).Add();//蛇增加一个节点
                Score++;//加一分
                this.AddQueue.Enqueue(new Apple());//随机生成一个苹果到添加队列
            }
            else if (sender is Snake && args.Target is Snake)//蛇自己碰到自己
            {
                this.AddQueue.Enqueue(new GameOver(this.Score));//游戏结束
                this.isPause = true;

            }
            else if (sender is Snake && args.Target is Border)//蛇碰到边框
            {
                this.AddQueue.Enqueue(new GameOver(this.Score));//游戏结束
                this.isPause = true;
            }
        }

        private void OnKeyDown(object sender, KeyDownEventArgs e)
        {
            //以下为按键映射
            if (e.KeyInfo.Key == ConsoleKey.W)//W
            {
                Player1.ChangeDirection(Direction.Up);
            }
            else if (e.KeyInfo.Key == ConsoleKey.D)//D
            {
                Player1.ChangeDirection(Direction.Right);
            }
            else if (e.KeyInfo.Key == ConsoleKey.S)//S
            {
                Player1.ChangeDirection(Direction.Down);
            }
            else if (e.KeyInfo.Key == ConsoleKey.A)//A
            {
                Player1.ChangeDirection(Direction.Left);
            }
            else if (e.KeyInfo.Key == ConsoleKey.UpArrow)//上
            {
                Player1.ChangeDirection(Direction.Up);
            }
            else if (e.KeyInfo.Key == ConsoleKey.RightArrow)//右
            {
                Player1.ChangeDirection(Direction.Right);
            }
            else if (e.KeyInfo.Key == ConsoleKey.DownArrow)//下
            {
                Player1.ChangeDirection(Direction.Down);
            }
            else if (e.KeyInfo.Key == ConsoleKey.LeftArrow)//左
            {
                Player1.ChangeDirection(Direction.Left);
            }
            else if (e.KeyInfo.Key == ConsoleKey.Enter)
            {
                if (this.Scene.Any(i => i is GameOver))//如果是GameOver
                {
                    this.Reset();
                }
                else
                {
                    this.isPause = !this.isPause;
                }
            }
            else if (e.KeyInfo.Key == ConsoleKey.Escape)
            {
                if (this.Scene.Any(i => i is GameOver))
                {
                    this.isQuit = true;
                }
            }
            else if (e.KeyInfo.Key == ConsoleKey.C)
            {
                this.Draw();
            }
        }

        //开始游戏
        private void Start()
        {
            Console.Title = "贪吃蛇";//窗口标题
            Console.CursorVisible = false;//隐藏光标
            Thread keydown = new Thread(ListenKeyDown);//实例化线程
            Thread gameLoop = new Thread(GameLoop);//实例化线程
            keydown.Start();//启动按键检测线程
            gameLoop.Start();//启动游戏循环线程
        }

        //监测按键        
        void ListenKeyDown()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            while (!this.isQuit)
            {
                var key = Console.ReadKey(true);//不把按下的按钮打印到终端
                if (key != keyInfo)//发生改变触发事件
                {
                    KeyDown(this, new KeyDownEventArgs { KeyInfo = key });
                }
            }
        }

        //游戏循环
        void GameLoop()
        {
            while (!this.isQuit)
            {
                if (!this.isPause)//暂停就不执行帧处理和碰撞检测
                {
                    foreach (IComponent c in this.Scene)
                    {
                        c.Frame();//通知所有的动画组件，该移动移动了
                    }
                    this.CollisionDetection();//动了以后看看，谁碰到谁了。碰撞检测
                    RemoveComponentFromScene();//从场景中移出要删除的对象
                    AddComponentToScene();     //增加对象到场景中
                    this.Draw();//绘制到终端
                }
                Thread.Sleep(Math.Max(10 * 1000 / (40 * this.Score + 80), 1));//等待绘制下一帧
            }
        }

        //添加元件到场景
        private void AddComponentToScene()
        {
            while (this.AddQueue.Count != 0)
            {
                this.Scene.Add(this.AddQueue.Dequeue());
            }
        }

        //删除元件到场景
        private void RemoveComponentFromScene()
        {
            while (this.RemoveQueue.Count != 0)
            {
                this.Scene.Remove(this.RemoveQueue.Dequeue());
            }
        }

        //碰撞检测
        void CollisionDetection()
        {
            //进行n*n次比较元件越慢
            foreach (AComponent c in this.Scene)
            {
                foreach (var target in this.Scene)
                {
                    if (c is Snake)//蛇碰撞到了自己
                    {
                        var snake = ((Snake)c);
                        for (var i = 1; i < snake.Shape.Count; i++)
                        {
                            if (snake.Shape[0].X == snake.Shape[i].X && snake.Shape[0].Y == snake.Shape[i].Y)
                            {
                                Collision(c, new CollisionEventArgs { Target = (AComponent)target });//触发碰撞
                            }
                        }
                    }

                    if (target != c)//蛇碰撞到了苹果
                    {
                        if (c.IsCollision(c, (AComponent)target))
                        {
                            Collision(c, new CollisionEventArgs { Target = (AComponent)target });//触发碰撞
                        }
                    }
                }
            }
        }

        //全黑色的帧
        IList<IList<Cell>> EmptyFrame()
        {
            var frame = new List<IList<Cell>>();
            for (int x = 0; x < ScreenWidth; x++)
            {
                frame.Add(new List<Cell>());
                for (int y = 0; y < ScreenHeight; y++)
                {
                    frame[x].Add(new Cell()
                    {
                        X = x,
                        Y = y,
                        Char = ' ',
                        Color = ConsoleColor.White,
                        BackgroundColor = ConsoleColor.Black
                    });
                }
            }
            return frame;
        }

        //获取两个帧的不同点
        IList<Cell> GetDifferenceCell(IList<IList<Cell>> m, IList<IList<Cell>> n)
        {
            var list = new List<Cell>();
            for (var x = 0; x < m.Count; x++)
            {
                for (var y = 0; y < m[x].Count; y++)
                {
                    var mCell = m[x][y];
                    var nCell = n[x][y];
                    if (mCell != nCell)//不相同就添加到列表中
                    {
                        list.Add(nCell);
                    }
                }
            }
            return list;
        }

        //帧转化为列表
        IList<Cell> FrameToList(IList<IList<Cell>> frame)
        {
            IList<Cell> list = new List<Cell>();
            for (var x = 0; x < frame.Count; x++)
            {
                for (var y = 0; y < frame[x].Count; y++)
                {
                    list.Add(frame[x][y]);
                }
            }
            return list;
        }

        void Clear()
        {
            var f = EmptyFrame();
            this.lastFrame = f;
            var list = FrameToList(f);
            this.Draw(list);
        }

        //全局绘制
        void Draw()
        {
            var f = EmptyFrame();      //创建空白帧
            foreach (var c in Scene)   //访问场景里的所有对象
            {
                c.Draw(f);//将元件绘制到帧上
            }
            var diff = GetDifferenceCell(lastFrame, f);//比较上一帧和当前帧的差异
            this.lastFrame = f;//保存当前帧
            Draw(diff);//把差异绘制到终端上
        }

        //绘制帧至屏幕
        void Draw(IList<Cell> list)
        {
            foreach (Cell cell in list)
            {
                Console.SetCursorPosition(cell.X, cell.Y);
                Console.ForegroundColor = cell.Color;
                Console.BackgroundColor = cell.BackgroundColor;
                Console.Write(cell.Char);//输出一个空格
            }
            Console.SetCursorPosition(0, 0);//整个终端的高宽绘制完成后把光标移动到最开始，以防止生成多余的行
        }
    }
}
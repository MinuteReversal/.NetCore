using System;
using System.Collections.Generic;

namespace SnakeGame
{
    //方向
    enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }

    //蛇
    class Snake : AComponent
    {

        Direction Direction = Direction.Right;

        public Snake()
        {
            //添加三个点
            this.shape.AddRange(new Cell[]{
            new Cell()
                {
                    X = 4,
                    Y = 1,
                    Char = '*',
                    Color = ConsoleColor.White,
                    BackgroundColor = ConsoleColor.Black
                },
                new Cell()
                {
                    X = 3,
                    Y = 1,
                    Char = '*',
                    Color = ConsoleColor.White,
                    BackgroundColor = ConsoleColor.Black
                },
                new Cell()
                {
                    X = 2,
                    Y = 1,
                    Char = '*',
                    Color = ConsoleColor.White,
                    BackgroundColor = ConsoleColor.Black
                }}
            );
        }

        public override void Frame()
        {
            this.Move();
        }

        private void Move()
        {
            Cell temp = new Cell(this.Shape[0]);
            Cell head = new Cell(this.Shape[0]);

            switch (this.Direction)
            {
                case Direction.Up:
                    head.Y -= 1;
                    head.Char = '^';
                    break;
                case Direction.Right:
                    head.X += 1;
                    head.Char = '>';
                    break;
                case Direction.Down:
                    head.Y += 1;
                    head.Char = 'v';
                    break;
                case Direction.Left:
                    head.X -= 1;
                    head.Char = '<';
                    break;
                default:
                    break;
            }

            //从取后一个移动
            for (var i = this.shape.Count - 1; i != 0; i--)
            {
                Cell current = this.shape[i];
                Cell preivious = this.shape[i - 1];
                current.X = preivious.X;
                current.Y = preivious.Y;
                this.shape[i] = current;
            }

            this.shape[0] = head;
        }

        public void Add()
        {
            var last = this.shape[this.shape.Count - 1];
            this.shape.Add(new Cell
            {
                X = last.X,
                Y = last.Y,
                Char = '*',
                Color = ConsoleColor.White,
                BackgroundColor = ConsoleColor.Black
            });
        }

        //改变方向
        public void ChangeDirection(Direction direction)
        {
            if (!IsReverse(direction))//接受非反向操作
            {
                this.Direction = direction;
            }
        }

        //反向输入
        public bool IsReverse(Direction direction)
        {
            if (this.Direction == Direction.Left && direction == Direction.Right)
            {
                return true;
            }
            else if (this.Direction == Direction.Right && direction == Direction.Left)
            {
                return true;
            }
            else if (this.Direction == Direction.Up && direction == Direction.Down)
            {
                return true;
            }
            else if (this.Direction == Direction.Down && direction == Direction.Up)
            {
                return true;
            }
            return false;
        }
    }
}
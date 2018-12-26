using System;
namespace SnakeGame
{
    //单元格
    public struct Cell
    {

        public static Cell Empty = new Cell();

        public Cell(Cell cell)
        {
            this.X = cell.X;
            this.Y = cell.Y;
            this.Char = cell.Char;
            this.Color = cell.Color;
            this.BackgroundColor = cell.BackgroundColor;
        }

        //X
        public int X { get; set; }

        //Y
        public int Y { get; set; }

        //文字
        public char Char { get; set; }

        //前景色
        public ConsoleColor Color { get; set; }

        //背景色
        public ConsoleColor BackgroundColor { get; set; }

        public static bool operator ==(Cell a, Cell b)
        {
            return a.Char == b.Char && a.BackgroundColor == b.BackgroundColor && a.Color == b.Color;
        }

        public static bool operator !=(Cell a, Cell b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

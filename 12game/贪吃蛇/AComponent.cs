using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    abstract public class AComponent : IComponent
    {
        protected List<Cell> shape = new List<Cell>();
        public List<Cell> Shape { get => shape; }

        //在帧上绘制图形
        public virtual void Draw(IList<IList<Cell>> frame)
        {
            foreach (var cell in this.shape)
            {
                frame[cell.X][cell.Y] = new Cell(cell);
            }
        }

        //默认碰撞检测
        public virtual bool IsCollision(AComponent m, AComponent n)
        {
            foreach (var mCell in m.Shape)
            {
                foreach (var nCell in n.Shape)
                {
                    if (mCell.X == nCell.X && mCell.Y == nCell.Y)//X,Y相同认为碰撞
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //渲染到此元件的时候会被调用
        public virtual void Frame() { }
    }
}
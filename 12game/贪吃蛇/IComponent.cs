using System.Collections.Generic;

namespace SnakeGame
{
    //动画组件接口,接口里只放功能签名
    public interface IComponent
    {
        //帧
        void Frame();
        //碰撞检测
        bool IsCollision(AComponent m, AComponent n);
        //在帧上画出图形
        void Draw(IList<IList<Cell>> frame);
    }
}
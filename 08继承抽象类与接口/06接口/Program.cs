using System;

namespace _06接口
{
    /*飞行的接口，一般接口中只定义方法的签名，由实现类去具体实现 */
    interface IFly
    {
        void Fly();//定义一个会飞行的功能
    }
    /*抽象鸟，一般抽象类只定义抽象方法，或以抽象的方式实现接口 */
    abstract class ABird : IFly
    {

        public abstract void Eat();//会吃
        public abstract void Fly();//会飞行
    }

    /* 抽象飞机 */
    abstract class APlane : IFly
    {
        public abstract void Refuel();//可以加油
        public abstract void Fly();//可以飞行
    }

    /*老鹰 */
    class Eagle : ABird
    {
        public override void Eat()
        {
            Console.WriteLine("老鹰喜欢吃肉");
        }

        public override void Fly()
        {
            Console.WriteLine("老鹰会飞翔");
        }
    }

    /*企鹅 */
    class Penguin : ABird
    {
        public override void Eat()
        {
            Console.WriteLine("企鹅喜欢吃鱼");
        }

        public override void Fly()
        {
            Console.WriteLine("企鹅不会飞行");
        }
    }
    /*F22战斗机 */
    class F22 : APlane
    {
        public override void Fly()
        {
            Console.WriteLine("F22飞得很快");
        }

        public override void Refuel()
        {
            Console.WriteLine("F22可以补给燃料");
        }
    }
    class ToyPlane : APlane
    {
        public override void Fly()
        {
            Console.WriteLine("无法对玩具飞机添加燃料");
        }

        public override void Refuel()
        {
            Console.WriteLine("玩具飞机也许可以飞行");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFly fly;
            fly = new Eagle();
            fly.Fly();
            fly = new Penguin();
            fly.Fly();
            fly = new F22();
            fly.Fly();
            fly = new ToyPlane();
            fly.Fly();
        }
    }

}

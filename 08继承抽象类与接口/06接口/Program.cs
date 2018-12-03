using System;

namespace _06接口
{
    interface IFly
    {
        void Fly();
    }

    abstract class ABird : IFly
    {

        public abstract void Eat();
        public abstract void Fly();
    }

    abstract class APlane : IFly
    {
        public abstract void Refuel();
        public abstract void Fly();
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            IFly fly;

            fly = new Eagle();
            fly.Fly();
            fly = new F22();
            fly.Fly();
        }
    }

}

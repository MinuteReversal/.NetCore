using System;

namespace _05抽象类
{
    abstract class ABird
    {

        public abstract void Eat();

        public abstract void Fly();
    }

    abstract class APlane
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
            ABird bird = new Eagle();
            APlane F22 = new F22();

            bird.Eat();
            bird.Fly();

            F22.Refuel();
            F22.Fly();
        }
    }
}

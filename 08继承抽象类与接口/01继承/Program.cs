using System;

namespace _01继承
{
    //Inheritance
    class Fish
    {
        protected string Name { get; set; }

        public Fish()
        {
            this.Name = "鱼";
        }

        public void Eat()
        {
            Console.WriteLine($"{this.Name}喜欢吃海带");
        }

        public void Swimming()
        {
            Console.WriteLine($"{this.Name}正在游泳");
        }

    }

    class FlyingFish : Fish
    {
        public FlyingFish()
        {
            this.Name = "飞鱼";
        }

        public void Fly()
        {
            Console.WriteLine($"{this.Name}会飞行");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var fish1 = new Fish();
            var flyingfish = new FlyingFish();

            fish1.Swimming();
            fish1.Eat();
            flyingfish.Swimming();
            flyingfish.Fly();
            flyingfish.Eat();
        }
    }
}

using System;

namespace _02隐藏
{
    //Inheritance
    class Fish
    {
        protected string Name { get; set; }
        public string Color { get; set; }
        public Fish(string color)
        {
            this.Name = "鱼";
            this.Color = color;
        }

        public void Eat()
        {
            Console.WriteLine($"{this.Name}喜欢吃海带");
        }

        public void Swimming()
        {
            Console.WriteLine($"{this.Color}颜色的{this.Name}正在游泳");
        }

    }

    class FlyingFish : Fish
    {
        public FlyingFish(string color) : base(color)
        {
            this.Name = "飞鱼";
        }

        public new void Eat()
        {
            Console.WriteLine($"{this.Color}色的{this.Name}喜欢吃海藻");
        }

        public void Fly()
        {
            Console.WriteLine($"{this.Color}色的{this.Name}会飞行");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var fish1 = new Fish("黄");
            var flyingfish = new FlyingFish("蓝");

            fish1.Eat();
            flyingfish.Eat();
        }
    }
}

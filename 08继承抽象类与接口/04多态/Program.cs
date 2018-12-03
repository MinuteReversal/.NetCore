using System;

namespace 多态
{//Inheritance
    class Fish
    {
        protected string Name { get; set; }
        public string Color { get; set; }
        public Fish(string color)
        {
            this.Name = "鱼";
            this.Color = color;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{this.Color}颜色的{this.Name}喜欢吃海带");
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


    class Shark : Fish
    {
        public Shark(string color) : base(color)
        {
            this.Name = "鲨鱼";
        }

        public override void Eat()
        {
            Console.WriteLine($"{this.Color}色的{this.Name}喜欢吃肉");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Fish fish;

            fish = new Fish("黄");
            fish.Eat();

            fish = new FlyingFish("蓝");
            fish.Eat();

            fish = new Shark("黑");
            fish.Eat();

            Console.WriteLine("对象在多态时new 用基类的方法，override用自己的");
        }
    }
}

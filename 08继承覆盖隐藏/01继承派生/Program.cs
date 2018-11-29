using System;

namespace _01继承派生
{
    //Inheritance
    class Fish
    {
        public string Color { get; set; }
        public Fish(string color)
        {
            this.Color = color;
        }
        public void Swimming()
        {
            Console.WriteLine($"{this.Color}颜色的鱼正在游泳");
        }

    }

    class Shark : Fish
    {
        public Shark(string color) : base(color) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fish1 = new Fish("黄色");
            var shark = new Shark("黑色");

            fish1.Swimming();
            shark.Swimming();
        }
    }
}

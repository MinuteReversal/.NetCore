﻿using System;

namespace base关键字
{//Inheritance
    class Fish
    {
        protected string Name { get; set; }
        private string Color { get; set; }

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
            Console.WriteLine($"{this.Name}正在游泳");
        }

    }

    class FlyingFish : Fish
    {
        public FlyingFish(string color) : base(color)
        {
            this.Name = "飞鱼";
        }

        public void Fly()
        {
            base.Swimming();
            Console.WriteLine($"{this.Name}在飞行");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            FlyingFish flyingfish = new FlyingFish("蓝");
            flyingfish.Fly();
        }
    }
}

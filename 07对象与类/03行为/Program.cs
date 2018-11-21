using System;

namespace _01构造器
{
    class Cat
    {
        public Cat() { }
        public Cat(string Color, string Name)
        {
            this.Color = Color;
            this.Name = Name;
        }
        public string Name;
        public string Color;        

        public void Eat(string food)
        {
            Console.WriteLine($"一只{this.Color}名字叫{this.Name}的猫吃下了{food}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat("白色", "Kitty");
            var cat2 = new Cat("蓝色", "哆啦A梦");
            var cat3 = new Cat("黄色", "Coffee");

            cat1.Eat("鱼");
            cat2.Eat("鱼");
            cat3.Eat("鱼");
        }
    }
}

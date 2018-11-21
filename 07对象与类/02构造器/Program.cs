using System;

namespace _01构造器
{
    class Cat
    {
        /*每当创建类或结构时，将会调用其构造函数 */
        public Cat() { }
        public Cat(string Color, string Name)
        {
            this.Color = Color;
            this.Name = Name;
        }
        public string Name;
        public string Color;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat("白色", "Kitty");
            var cat2 = new Cat("蓝色", "哆啦A梦");
            var cat3 = new Cat("黄色", "Coffee");
        }
    }
}

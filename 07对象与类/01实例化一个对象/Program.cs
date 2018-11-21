using System;

namespace _01实例化一个对象
{
    class Cat
    {
        public string Color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat();
            cat1.Color = "Yellow";
            var cat2 = new Cat();
            cat2.Color = "White";
            var cat3 = new Cat();
            cat3.Color = "Black";

        }
    }
}

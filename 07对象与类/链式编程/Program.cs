using System;

namespace 链式编程
{
    //定义一个类A
    class A
    {
        public A(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public A Drink()
        {
            Console.WriteLine(this.Name + "在喝水");
            return this;
        }

        public A Eat()
        {
            Console.WriteLine(this.Name + "在吃东西");
            return this;
        }

        public A Run()
        {
            Console.WriteLine(this.Name + "在跑步");
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new A("AAA").Eat().Run().Drink();//实例化A类，调用其成员方法
        }
    }
}

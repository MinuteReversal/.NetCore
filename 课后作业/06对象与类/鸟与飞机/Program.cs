/*
*
设计一个鸟的类，让鸟飞起来
设计一个飞机的类，让飞机飞起来
*
 */
using System;

namespace 鸟与飞机
{
    //鸟类
    class Bird
    {
        public void Fly()
        {
            Console.WriteLine("鸟在天空中飞翔");
        }
    }
    //飞机类
    class Plane
    {
        public void Fly()
        {
            Console.WriteLine("飞机在天空中飞行");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Bird().Fly();
            new Plane().Fly();
        }
    }
}

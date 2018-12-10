using System;

namespace _01单例模式
{
    //单例
    public class Singleton
    {
        private static readonly Singleton singleton = new Singleton(); //限制 产生 多个 对象 
        private Singleton() { } //私有的构造器，不允许外部使用new运算符直接实例化Singleton类的对象

        //通过 该 方法 获得 实例 对象 
        public static Singleton getSingleton()
        {
            return singleton;
        }
        public void doSomething()
        {
            Console.WriteLine("可以做一些事情。");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //在全局范围里只会有一个实例
            Singleton singleton1 = Singleton.getSingleton();//只能通过方法获取Singleton的实例
            Singleton singleton2 = Singleton.getSingleton();//只能通过方法获取Singleton的实例
            singleton1.doSomething();
            singleton2.doSomething();
            Console.WriteLine(singleton1 == singleton2);//比较一下singleton1和singleton2是不是指向同一个地址
        }
    }
}

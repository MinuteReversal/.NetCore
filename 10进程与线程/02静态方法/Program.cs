using System;

namespace 静态方法
{
    class A
    {
        public static string Name { get; set; }
        public static void Run()//静态方方法只能访问静态成员
        {
            Console.WriteLine("A run");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new A();
            A.Run();            
        }
    }
}

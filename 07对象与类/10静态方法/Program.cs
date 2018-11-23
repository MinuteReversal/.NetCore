using System;

namespace 静态方法
{
    class A
    {
        public string Name { get; set; }
        public static void Run()
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

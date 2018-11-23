using System;

namespace 静态字段
{
    class A
    {
        public static string Name;//静态字段属于类所有,所有实例共有此字段
        public void Run()
        {
            Console.WriteLine(Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A.Name = "hello";
            var a = new A();
            var a1 = new A();
            a.Run();
            a1.Run();
            A.Name = "888";
            a.Run();
            a1.Run();

        }
    }
}

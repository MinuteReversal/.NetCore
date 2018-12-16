using System;

namespace 静态字段
{
    class A
    {
        public static string Name;//静态字段属于类所有
        public void Run()
        {
            Console.WriteLine(A.Name);//通过类名访问
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            A.Name = "hello";
            var a1 = new A();
            var a2 = new A();

            a1.Run();
            a1.Run();
            
            A.Name = "888";
            a2.Run();
            a1.Run();

        }
    }
}

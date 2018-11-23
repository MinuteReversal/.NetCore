using System;

namespace 静态类
{
    /* 无法实例化 */
    static class A
    {
        public static string Name;//只能包含静态成员
        public static void Run()//只能包含静态成员
        {
            Console.WriteLine("A run");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            A.Name = "abc";
            A.Run();
        }
    }
}

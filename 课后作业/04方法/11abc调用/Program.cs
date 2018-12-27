/*
*实现A-B-C方法调用
*/
using System;

namespace _11abc调用
{
    class Program
    {
        static void Main(string[] args)
        {
            A();
        }

        static void A()
        {
            Console.WriteLine("A Start");
            B();
            Console.WriteLine("A End");
        }

        static void B()
        {
            Console.WriteLine("B StBrt");
            C();
            Console.WriteLine("B End");
        }

        static void C()
        {
            Console.WriteLine("C Start");
            Console.WriteLine("C End");
            return;
        }
    }
}

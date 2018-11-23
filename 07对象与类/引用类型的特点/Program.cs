using System;
using System.Linq;

namespace 引用类型的特点
{
    class Program
    {

        class A
        {
            public A(string name)
            {
                Name = name;
            }
            public string Name;
        }

        static void Main(string[] args)
        {
            var a = new A("Hello");
            var b = a;
            var c = a;

            Console.WriteLine($"a:{a.Name}");
            Console.WriteLine($"b:{b.Name}");
            Console.WriteLine($"c:{c.Name}");

            a.Name = "world";
            Console.WriteLine($"a:{a.Name}");
            Console.WriteLine($"b:{b.Name}");
            Console.WriteLine($"c:{c.Name}");
        }
    }
}

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
            var a = new A("Hello");//对A对象创建了一个快捷方式a
            var b = a;             //创建一个快捷方式b指向A的对象
            var c = a;             //创建一个快捷方式c指向A的对象

            Console.WriteLine($"a:{a.Name}");
            Console.WriteLine($"b:{b.Name}");
            Console.WriteLine($"c:{c.Name}");

            a.Name = "world";     //使用快捷方式修改了对象A的成员
            Console.WriteLine($"a:{a.Name}");
            Console.WriteLine($"b:{b.Name}");
            Console.WriteLine($"c:{c.Name}");
        }
    }
}

using System;

namespace 嵌套
{
    class B
    {
        public string Name { get; set; }
    }

    class A
    {
        public B member = new B();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a.member.Name = "abc";
        }
    }
}

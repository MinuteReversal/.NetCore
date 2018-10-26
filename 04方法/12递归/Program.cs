using System;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            Fn();
        }

        static void Fn()
        {
            Fn();
        }
    }
}

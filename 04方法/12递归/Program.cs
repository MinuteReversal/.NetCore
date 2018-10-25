using System;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            FnR();
        }

        static void FnR()
        {
            FnR();
        }
    }
}

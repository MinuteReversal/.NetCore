using System;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FnAdd(100));
        }

        static int FnAdd(int end)
        {
            if (end == 1) return end;
            return end + FnAdd(end - 1);
        }
    }
}

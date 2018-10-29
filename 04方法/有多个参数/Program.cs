using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            ManyParams("a", "b", "c");
        }

        static void ManyParams(params string[] args)
        {
            foreach (var a in args)
            {
                Console.WriteLine(a);
            }
        }
    }
}


using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //非
            bool n1 = !true;
            bool n2 = !false;

            Console.WriteLine($"{n1},{n2}");

            //与
            bool a1 = true && true;
            bool a2 = true && false;
            bool a3 = false && true;
            bool a4 = false && false;
            Console.WriteLine($"{a1},{a2},{a3},{a4}");

            //或
            bool o1 = true || true;
            bool o2 = false || true;
            bool o3 = true || false;
            bool o4 = false || false;
            Console.WriteLine($"{o1},{o2},{o3},{o4}");

            //异或
            bool x1 = true ^ true;
            bool x2 = false ^ true;
            bool x3 = true ^ false;
            bool x4 = false ^ false;

            Console.WriteLine($"{x1},{x2},{x3},{x4}");
        }
    }
}

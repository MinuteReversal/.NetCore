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

            //与
            bool a1 = true && true;
            bool a2 = true && false;
            bool a3 = false && true;
            bool a4 = false && false;

            //或
            bool o1 = true || true;
            bool o2 = false || true;
            bool o3 = true || false;
            bool o4 = false || false;
   
        }
    }
}

using System;

namespace forfor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Console.Write(i + "" + j + ",");
                }
                Console.Write("\r\n");
            }
        }
    }
}

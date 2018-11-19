using System;

namespace 交换
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, t;
            string[] inputs = Console.ReadLine().Split(" ");
            x = int.Parse(inputs[0]);
            y = int.Parse(inputs[1]);
            z = int.Parse(inputs[2]);

            Console.WriteLine("{0},{1},{2}", x, y, z);

        }
    }
}

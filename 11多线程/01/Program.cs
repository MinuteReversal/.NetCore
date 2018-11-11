using System;
using System.Threading;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(
                () =>
                {
                    Console.WriteLine("***");
                }
            );
            thread.Start();
        }
    }
}

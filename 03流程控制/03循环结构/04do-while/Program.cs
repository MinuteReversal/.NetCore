using System;

namespace _04do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;//改为6
            do
            {
                i += 1;
                Console.WriteLine(i);
            } while (i < 5);
        }
    }
}

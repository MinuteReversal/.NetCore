using System;

namespace UTF8Find
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            do
            {
                Console.WriteLine("input word");
                input = Console.ReadLine();
                Console.WriteLine($"{input}:{GetCode(input[0]).ToString("X")}");

            } while (input != "\u001B");
        }

        static int GetCode(char c)
        {
            for (var i = 0; i < 0xFFFF; i++)
            {
                if ((char)i == c)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

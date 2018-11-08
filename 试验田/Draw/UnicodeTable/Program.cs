using System;

namespace UnicodeTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.UnicodeEncoding.UTF8;
            Console.Write((char)0 == '\u0000');
            for (var i = -1; i <= 0xFFFF / 6; i += 10)
            {
                for (var j = 0; j <= 0xF; j++)
                {
                    Console.Write("\u0020");
                    Console.Write((char)(i + j));
                }
                Console.WriteLine();
            }
        }
    }
}

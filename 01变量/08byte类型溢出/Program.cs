using System;

namespace app
{
    public class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;

            b++;
            Console.WriteLine(b);
            b += 1;
            Console.WriteLine(b);
            b = (byte)(b + 1);
            Console.WriteLine(b);

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/byte
            byte b1 = 201;
            byte b2 = 0x00c9;
            byte b3 = 0b1100_1001;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
        }
    }
}

using System;
using System.Text;
namespace menu
{
    class Program
    {

        //https://stackoverflow.com/questions/20999247/how-to-prevent-the-console-to-write-a-character-in-the-last-line
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            MenuBox();
        }

        static void MenuBox()
        {
            Console.SetCursorPosition(0, 0);
            for (var y = 0; y < Console.WindowHeight; y++)
            {
                for (var x = 0; x < Console.WindowWidth; x++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadKey();
        }
    }
}

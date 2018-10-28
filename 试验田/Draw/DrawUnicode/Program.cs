using System;

namespace DrawUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] rList = new char[] { (char)9617, (char)9618, (char)9619, (char)9608 };
            foreach (var item in rList)
            {
                Console.Write(item);
            }

            char[] spList = new char[] { '\u2593' };
            Console.WriteLine(spList[0] == rList[2]);

            char[] chars = { '█', '▓', '▒', '░' };
            foreach (var c in chars)
            {
                Console.Write(c);
            }
        }
    }
}

using System;

namespace DrawUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.OutputEncoding);
            Console.OutputEncoding = System.Text.Encoding.UTF8;//非常重要

            char[] rList = new char[] { (char)9617, (char)9618, (char)9619, (char)9608 };
            char[] uList = { '\u2590', '\u2591', '\u2592', '\u2593' };
            char[] bList = { '\u25A4', '\u25A5', '\u25A6', '\u25A7', '\u25A8', '\u25A9' };
            char[] buttons = { '\u23E9', '\u23EA', '\u23EB', '\u23EC', '\u23ED', '\u23EE', '\u23EF', '\u23F5', '\u23F6', '\u23F7', '\u23F8', '\u23F9', '\u23FA' };
            char[] palyCard = { '\u2660', '\u2661', '\u2662', '\u2663', '\u2664', '\u2665', '\u2666', '\u2667' };

            Console.WriteLine(string.Join("", rList));
            Console.WriteLine(string.Join("", uList));
            Console.WriteLine(string.Join("", bList));
            Console.WriteLine(string.Join("  ", buttons));
            Console.WriteLine(string.Join(" ", palyCard));
        }
    }
}

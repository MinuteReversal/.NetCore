using System;

namespace _06常量
{
    class Program
    {
        static void Main(string[] args)
        {
            //常量
            //前缀
            Console.WriteLine(0b1111_1111);/*二进制*/
            Console.WriteLine(85);  /* 十进制 */
            Console.WriteLine(0x4b);/* 十六进制 */

            //后缀
            Console.WriteLine(30);  /* int */
            Console.WriteLine(30u); /* 无符号 int */
            Console.WriteLine(30L); /* long */
            Console.WriteLine(30UL);/* 无符号 long */
            Console.WriteLine(30f); /* float */
            Console.WriteLine(30d); /* double */
            Console.WriteLine(30m); /* decimal */
            Console.WriteLine('A'); /* char */

            var bin = 0b1111_1111;
            var dec = 85;
            var oct = 0123;
            var hex = 0x4b;

            var i = 30;
            var u = 30u;
            var l = 30L;
            var ul = 30UL;
            var f = 30f;
            var db = 30d;
            var deci = 30m;
            var c = 'A';

            Console.WriteLine(bin.GetType());
            Console.WriteLine(dec.GetType());
            Console.WriteLine(oct.GetType());
            Console.WriteLine(hex.GetType());
            Console.WriteLine("****************");
            Console.WriteLine(i.GetType());
            Console.WriteLine(u.GetType());
            Console.WriteLine(l.GetType());
            Console.WriteLine(ul.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(db.GetType());
            Console.WriteLine(deci.GetType());
            Console.WriteLine(c.GetType());
        }
    }
}

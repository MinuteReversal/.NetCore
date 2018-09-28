using System;

namespace app
{
    class Program
    {
        enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        public struct Book
        {
            public decimal price;
            public string title;
            public string author;
        }

        static void Main(string[] args)
        {
            //字面量 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/byte
            bool b = true;
            byte bt1 = 0b0000_00001;
            int i1 = 0xfffff;
            float f1 = 0.1f;
            decimal d1 = 0.2222m;
            char c1 = 'X';
            char c2 = '\x0058';
            char c3 = '\u0058';
            double d = 3d;
            float f = 1.01f;
            long l = 4294967296;
            sbyte sbt = sbyte.MinValue;

        }
    }
}

using System;

namespace _01数据类型从大到小
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型变量
            //https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/built-in-types-table
            bool b = false;  //布尔 true false
            /*char 可隐式转换为 ushort、int、uint、long、ulong、float、double 或 decimal。 但是无法将其他类型隐式转换为 char 类型。 */
            char c = 'A';    //字符 ASCII 127个 unicode

            sbyte sbt = -128;//有符号字节 -128~127
            byte bt = 123;   //字节 0~255
            short st = -777;  //有符号短整型
            ushort ust = 999; //无符号短整型
            int i = -789;    //有符号整型
            uint ui = 789;   //无符号整型
            long l = -666L;   //L后缀
            ulong ul = 888L;  //无符号长整型


            float f = -3.5F;  //有符号单精度
            double db = -3D;   //有符号双精度
            decimal dec = -456.5m; //128 位 财务和货币计算



            //有符号从小到大
            st = sbt;
            i = st;
            l = i;
            f = l;
            db = f;

            Console.WriteLine(st);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(db);

            //无符号从小到大
            ust = bt;
            ui = ust;
            ul = ui;
            f = ul;
            db = f;

            Console.WriteLine(ust);
            Console.WriteLine(ui);
            Console.WriteLine(ul);
            Console.WriteLine(f);
            Console.WriteLine(db);
        }
    }
}

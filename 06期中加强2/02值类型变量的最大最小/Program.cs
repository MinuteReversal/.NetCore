using System;

namespace _03值类型变量的最大最小
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型变量
            //https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/built-in-types-table
            bool bMax = true;  //布尔 true false
            bool bMin = false;
            /*char 可隐式转换为 ushort、int、uint、long、ulong、float、double 或 decimal。 但是无法将其他类型隐式转换为 char 类型。 */
            char cMax = char.MaxValue;    //字符 ASCII 127个 unicode
            char cMin = char.MinValue;

            //整数类型
            sbyte sbtMax = sbyte.MaxValue;//有符号字节 -128~127
            sbyte sbtMin = sbyte.MinValue;//有符号字节 -128~127
            byte btMax = byte.MaxValue;   //字节 0~255
            byte btMin = byte.MinValue;   //字节 0~255
            short stMax = short.MaxValue;  //有符号短整型
            short stMin = short.MinValue;  //有符号短整型
            ushort ustMax = ushort.MaxValue; //无符号短整型
            ushort ustMin = ushort.MinValue; //无符号短整型
            int iMax = int.MaxValue;    //有符号整型
            int iMin = int.MinValue;    //有符号整型
            uint uiMax = uint.MaxValue;   //无符号整型
            uint uiMin = uint.MinValue;   //无符号整型
            long lMax = long.MaxValue;   //长整型L后缀
            long lMin = long.MinValue;
            ulong ulMax = ulong.MaxValue;  //无符号长整型
            ulong ulMin = ulong.MinValue;  //无符号长整型


            //浮点型变量
            float fMax = float.MaxValue;  //有符号单精度
            float fMin = float.MinValue;  //有符号单精度
            double dbMax = double.MaxValue;   //有符号双精度
            double dbMin = double.MinValue;   //有符号双精度
            decimal decMax = decimal.MaxValue; //128 位 财务和货币计算
            decimal decMin = decimal.MinValue; //128 位 财务和货币计算

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(bMax);
            Console.WriteLine(bMin);
            Console.WriteLine(cMax);
            Console.WriteLine(cMin);
            Console.WriteLine(sbtMax);
            Console.WriteLine(sbtMin);
            Console.WriteLine(btMax);
            Console.WriteLine(btMin);
            Console.WriteLine(stMax);
            Console.WriteLine(stMin);
            Console.WriteLine(ustMax);
            Console.WriteLine(ustMin);
            Console.WriteLine(iMax);
            Console.WriteLine(iMin);
            Console.WriteLine(uiMax);
            Console.WriteLine(uiMin);
            Console.WriteLine(lMax);
            Console.WriteLine(lMin);
            Console.WriteLine(ulMax);
            Console.WriteLine(ulMin);
            Console.WriteLine(fMax);
            Console.WriteLine(fMin);
            Console.WriteLine(dbMax);
            Console.WriteLine(dbMin);
            Console.WriteLine(decMax);
            Console.WriteLine(decMin);
        }
    }
}

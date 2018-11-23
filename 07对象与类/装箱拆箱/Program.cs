using System;

namespace 装箱拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/types/boxing-and-unboxing
            int i = 100;
            object i1 = i;
            object i2 = i;
            Console.WriteLine($"i:{i}");
            Console.WriteLine($"i1:{i1}");
            Console.WriteLine($"i2:{i2}");

            i = 666;
            Console.WriteLine($"i:{i.GetType().IsValueType}");
            Console.WriteLine($"i1:{i1.GetType().IsValueType}");
            Console.WriteLine($"i2:{i2.GetType().IsValueType}");
            Console.WriteLine($"i:{i}");
            Console.WriteLine($"i1:{i1}");
            Console.WriteLine($"i2:{i2}");
        }
    }
}

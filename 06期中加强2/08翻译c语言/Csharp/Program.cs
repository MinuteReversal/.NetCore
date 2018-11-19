using System;

namespace Csharp
{
    class Program
    {
        const int length = 10; // 定义杨辉三角的大小
        static void Main(string[] args)
        {
            int[,] nums = new int[length, length];
            int i, j;
            /*计算杨辉三角*/
            for (i = 0; i < length; i++)
            {
                nums[i, 0] = 1;
                nums[i, i] = 1;
                for (j = 1; j < i; j++)
                    nums[i, j] = nums[i - 1, j - 1] + nums[i - 1, j];
            }
            /*打印输出*/
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length - i - 1; j++)
                    Console.Write("   ");
                for (j = 0; j <= i; j++)
                    //https://docs.microsoft.com/zh-cn/dotnet/api/system.console.write?view=netframework-4.7.2#System_Console_Write_System_String_System_Object_
                    Console.Write("{0,-5} ", nums[i, j]);//格式左对齐格式项的语法是{索引[,对齐] [:formatString]}
                Console.Write('\n');
            }
        }
    }
}

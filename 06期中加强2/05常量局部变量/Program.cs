using System;

namespace _05常量局部变量
{
    class Program
    {
        const double gravitationalConstant = 6.673e-11;//常量字段
        const string productName = "Visual C#";        //常量字段
        static void Main(string[] args)
        {
            //常量字段和常量局部变量不是变量并且不能修改。
            const int x = 0;//常量变量

            Console.WriteLine(gravitationalConstant);
            Console.WriteLine(productName);
            Console.WriteLine(x);

        }
    }
}

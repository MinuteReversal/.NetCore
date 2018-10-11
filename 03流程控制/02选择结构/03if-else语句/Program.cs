using System;

namespace _03if_else语句
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 100;
            /* 检查布尔条件 */
            if (a < 20)
            {
                /* 如果条件为真，则输出下面的语句 */
                Console.WriteLine("a 小于 20");
            }
            else
            {
                /* 如果条件为假，则输出下面的语句 */
                Console.WriteLine("a 大于等于 20");
            }
            Console.WriteLine("a 的值是 {0}", a);

        }
    }
}

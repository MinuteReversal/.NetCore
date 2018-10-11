using System;

namespace _04if_elseif_else语句
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 100;

            /* 检查布尔条件 */
            if (a == 10)
            {
                /* 如果 if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 10");
            }
            else if (a == 20)
            {
                /* 如果 else if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 20");
            }
            else if (a == 30)
            {
                /* 如果 else if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 30");
            }
            else
            {
                /* 如果上面条件都不为真，则输出下面的语句 */
                Console.WriteLine("没有匹配的值");
            }
            Console.WriteLine("a 的准确值是 {0}", a);

        }
    }
}

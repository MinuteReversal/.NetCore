using System;

namespace 异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            //语法错误
            //逻辑错误

            try
            {
                var x = 0;
                var y = 100;
                Console.WriteLine(y / x);
                Inputscore(300);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("无论成功失败都要执行");
            }
            Console.WriteLine("执行");
        }

        static void Inputscore(uint score)
        {
            if (score > 100)
            {
                throw new Exception("分数超出100的限制");
            }
        }
    }
}

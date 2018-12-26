using System;

namespace _01制造一个异常
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;
            int r = 0;

            try
            {
                r = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(r);
            }
        }
    }
}

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
            int[] a = new int[1];

            try
            {
                //r = x / y;
                r = a[1];
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
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

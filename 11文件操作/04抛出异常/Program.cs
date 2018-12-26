using System;

namespace _04抛出异常
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SetBrightness(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static void SetBrightness(int val)
        {
            if (val <= 10 || val >= 100) throw new ArgumentOutOfRangeException("亮度超过限制");
        }
    }
}

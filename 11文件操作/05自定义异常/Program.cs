using System;

namespace _04抛出异常
{
    class BrightnessOutOfRangeException : Exception
    {
        public BrightnessOutOfRangeException(string Message) : base(Message)
        {

        }
    }

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
            if (val <= 10 || val >= 100) throw new BrightnessOutOfRangeException("亮度超过限制");
        }
    }
}

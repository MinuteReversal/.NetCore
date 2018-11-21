using System;

namespace _04属性的进化
{
    class Watch
    {
        public int Hours;
        public int Minutes;
        public int Seconds;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Watch();
            watch.Hours = 123;
            watch.Minute = 456;
            watch.Seconds = 789;
        }
    }
}

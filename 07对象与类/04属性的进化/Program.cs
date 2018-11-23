using System;

namespace _04属性的进化
{
    class Watch
    {
        public int Hour;
        public int Minute;
        public int Second;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Watch();
            watch.Hour = 123;
            watch.Minute = 456;
            watch.Second = 789;
        }
    }
}

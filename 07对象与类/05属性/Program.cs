using System;

namespace _05属性
{
    class Watch
    {
        private int _hour;//字段首字母大写
        private int _minute;//字段首字母大写
        private int _second;//字段首字母大写

        //参数名首字母小写
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value > 0 && value < 24)
                {
                    _hour = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hour 超过0-23的限制！");
                }
            }
        }
        #region 属性
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value > 0 && value < 59)
                {
                    _minute = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Minute 超过0-59的限制！");
                }
            }
        }

        public int Second
        {
            get { return _second; }
            set
            {
                if (value > 0 && value < 59)
                {
                    _second = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Second 超过0-59的限制！");
                }
            }
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Watch();
            watch.Hour = 23;
            watch.Minute = 30;
            watch.Second = 30;
            Console.WriteLine($"{watch.Hour}:{watch.Minute}:{watch.Second}");
        }
    }
}

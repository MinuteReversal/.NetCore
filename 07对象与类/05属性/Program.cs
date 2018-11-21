using System;

namespace _05属性
{
    class Program
    {
        class Watch
        {
            private int Hour;//字段首字母大写
            private int Minute;//字段首字母大写
            private int Second;//字段首字母大写

            //参数名首字母小写
            public void SetHour(int hour)
            {
                if (hour > 0 && hour < 24)
                {
                    Hour = hour;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("hours 超过0-23的限制！");
                }
            }

            public int GetHour()
            {
                return Hour;
            }

            public void SetMinute(int minute)
            {
                if (minute > 0 && minute < 60)
                {
                    Minute = minute;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("hours 超过0-23的限制！");
                }
            }

            public int GetMinute()
            {
                return Minute;
            }

            public void SetSecond(int second)
            {
                if (second > 0 && second < 60)
                {
                    Second = second;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("hours 超过0-23的限制！");
                }
            }

            public int GetSecond()
            {
                return Second;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var watch = new Watch();
                watch.SetHour(23);
                watch.SetMinute(59);
                watch.SetSecond(29);
                Console.WriteLine($"{watch.GetHour()}:{watch.GetMinute()}:{watch.GetSecond()}");
            }
        }
    }
}

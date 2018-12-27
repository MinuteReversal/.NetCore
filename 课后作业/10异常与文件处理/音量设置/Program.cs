/*
写一个设置音量的方法
音量大小有效值范围是0-100
调用者调用这个方法设置音量
超过范围
抛出异常
*/
using System;

namespace 音量设置
{
    class VolumeOutOfRangeException : Exception
    {
        public VolumeOutOfRangeException(string Message) : base(Message)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SetVolume(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void SetVolume(int val)
        {
            if (val < 0 || val > 100) throw new VolumeOutOfRangeException("音量超过限制");
            Console.WriteLine($"音量被设置到了{val}");
        }
    }
}

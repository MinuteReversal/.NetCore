using System;
using System.Threading;//引入线程命名空间

namespace 一边弹吉他一边唱歌词
{
    //艺术家
    class Artist
    {
        static void Main(string[] args)
        {
            //多线程技术可以提高硬件的使用效率
            Thread singThread = new Thread(Singing);        //实例化一个线程，并把歌唱方法设置给线程
            Thread playThread = new Thread(PlayingGuitar); //实例化一个线程，并把演奏方法设置给线程

            singThread.Start();//启动歌唱线程
            playThread.Start();//启动演奏线程

            /* 这两个线程同时执行,在终端里按下ctrl+c停止运行些示例 */
        }

        //歌唱
        static void Singing()
        {
            while (true)
            {
                Console.WriteLine("正在歌唱");
            }

        }

        //演奏
        static void PlayingGuitar()
        {
            while (true)
            {
                Console.WriteLine("演奏吉他");
            }
        }
    }
}

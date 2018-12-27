/*
*
1、有A、B、C三个订阅者都订阅了意林杂志
2、本期意林杂志出版了，为ABC三个订阅者分发杂志。
 */
using System;

namespace 意林杂志
{
    //杂志社    
    class PeriodicalOffice
    {
        public event EventHandler Subscribe;
        public void Publish()
        {
            //派发内容
            Subscribe(this, new Magazine { Content = "很多有意思的文章。" });
        }
    }

    //意林杂志
    public class Magazine : EventArgs
    {
        public string Content { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var wx = new PeriodicalOffice();
            wx.Subscribe += SubscriberA;//订阅
            wx.Subscribe += SubscriberB;//订阅            
            wx.Subscribe += SubscriberC;//订阅   
            wx.Publish();//出版
        }

        //订户A
        static void SubscriberA(object sender, EventArgs e)
        {
            Console.WriteLine("订户A收到：" + (e as Magazine).Content);
        }

        //订户B
        static void SubscriberB(object sender, EventArgs e)
        {
            Console.WriteLine("订户B收到：" + (e as Magazine).Content);
        }

        //订户C
        static void SubscriberC(object sender, EventArgs e)
        {
            Console.WriteLine("订户C收到：" + (e as Magazine).Content);
        }
    }
}

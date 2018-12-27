using System;

namespace 微信消息订阅与推送
{
    //微信
    class Wechat
    {
        public event EventHandler Subscribe;
        public void Send()
        {
            //派发内容
            Subscribe(this, new MessageContent { Message = "2019年元旦放假三天。" });
        }
    }

    //消息内容    
    class MessageContent : EventArgs
    {
        public string Message { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var wx = new Wechat();
            wx.Subscribe += SubscriberA;//订阅
            wx.Subscribe += SubscriberB;//订阅            
            wx.Subscribe += SubscriberC;//订阅   
            wx.Send();//微信推送消息
        }

        //订户A
        static void SubscriberA(object sender, EventArgs e)
        {
            Console.WriteLine("订户A收到：" + (e as MessageContent).Message);
        }

        //订户B
        static void SubscriberB(object sender, EventArgs e)
        {
            Console.WriteLine("订户B收到：" + (e as MessageContent).Message);
        }

        //订户C
        static void SubscriberC(object sender, EventArgs e)
        {
            Console.WriteLine("订户C收到：" + (e as MessageContent).Message);
        }
    }
}

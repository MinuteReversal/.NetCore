using System;

namespace app
{
    #region  广播站    
    class BroadcastingStation
    {
        public event EventHandler Broadcast;
        public void play()
        {
            //派发内容
            Broadcast(this, new BroadcastContent { Message = "10月1日国庆放假7天" });
        }
    }

    //广播的内容
    class BroadcastContent : EventArgs
    {
        public string Message;
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            var bs = new BroadcastingStation();
            bs.Broadcast += Listener1;//订阅
            bs.Broadcast += Listener2;//订阅
            bs.play();
        }

        /*
        * 听众1
        */
        static void Listener1(object sender, EventArgs e)
        {
            Console.WriteLine("听众1听到了" + (e as BroadcastContent).Message);
        }

        /*
        * 听众2
        */
        static void Listener2(object sender, EventArgs e)
        {
            Console.WriteLine("听众2听到了" + (e as BroadcastContent).Message);
        }
    }
}

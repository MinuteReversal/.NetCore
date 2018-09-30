using System;

namespace app
{
    class BroadcastingStation
    {
        public event EventHandler Broadcast;
        public void play()
        {
            Broadcast(this, new BroadcastContent { Message = "10月1日国庆放假7天" });
        }
    }

    class BroadcastContent : EventArgs
    {
        public string Message;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bs = new BroadcastingStation();
            bs.Broadcast += Listener1;            
            bs.Broadcast += Listener2;
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
        * 听众1
        */
        static void Listener2(object sender, EventArgs e)
        {
            Console.WriteLine("听众2听到了" + (e as BroadcastContent).Message);
        }
    }
}

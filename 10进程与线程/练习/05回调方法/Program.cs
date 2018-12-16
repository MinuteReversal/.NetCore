using System;

namespace _05回调方法
{

    delegate void OnArrived();
    class Postman
    {
        public void Send(string target, string content, OnArrived callbackFn)
        {
            Console.WriteLine($"向{target}派送的{content}已到达");
            callbackFn();//向发件者发送已到达的信息
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string tname = "莉莉";
            Postman postman = new Postman();
            Console.WriteLine($"让快递送水果给{tname}");
            postman.Send(tname, "水果", () =>
             {
                 Console.WriteLine("对快递员进行五星好评");
             });
        }
    }
}

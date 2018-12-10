using System;

namespace 接口
{
    //接口无法被new
    interface IFather
    {
        void Coding();//会写程序
    }

    interface IMother
    {
        void PlayPiano();//会弹钢琴
    }

    class Child : IFather, IMother//孩子实现了父亲和母亲的愿望
    {        
        public void Coding()
        {
            Console.WriteLine("孩子实现了父亲会写程序的愿望");
        }

        public void PlayPiano()
        {
            Console.WriteLine("孩子实现了母亲会弹钢琴的愿望");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Coding();
            child.PlayPiano();
        }
    }
}

using System;
using System.Threading;

namespace 并发
{
    class BookShop
    {
        private int num = 1;
        public void Sale()
        {
            if (num > 0)
            {
                Thread.Sleep(1);
                num--;
                Console.WriteLine("出售一本书，还乘余{0}本", num);
            }
            else
            {
                Console.WriteLine("已售完");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookShop bookShop = new BookShop();
            Thread thread1 = new Thread(bookShop.Sale);
            Thread thread2 = new Thread(bookShop.Sale);

            thread1.Start();
            thread2.Start();
        }
    }
}

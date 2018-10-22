using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine(i++);//0
            Console.WriteLine(i);   //1
            Console.WriteLine(++i);//2
            Console.WriteLine(i);  //2
            Console.WriteLine(i--);//2
            Console.WriteLine(i);  //1
            Console.WriteLine(--i);//0
            Console.WriteLine(i);
        }
    }
}

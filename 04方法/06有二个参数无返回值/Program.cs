using System;

namespace _02有参数无返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            Fn2(999,"hello word");
        }

        static void Fn2(int a,string word)//int a=999;string word="hello word";
        {
            Console.WriteLine($"传入的值是{a}{word}");
        }
    }
}

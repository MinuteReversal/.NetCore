using System;

namespace _07泛型
{

    class Test<T>//定义时类型不明确
    {
        public Test(T m)
        {
            this.Member = m;
        }

        private T Member { get; set; }
        public void Print()
        {
            Console.WriteLine(this.Member);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Print(123);//使用时必须明确
            Print("abc");
            Print(3.14);

            Test<int> test = new Test<int>(100);//使用时必须明确
            test.Print();
        }

        static void Print<T>(T param)//定义时类型不明确
        {
            Console.WriteLine(param);
        }
    }
}

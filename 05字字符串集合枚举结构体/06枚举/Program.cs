using System;

namespace 枚举
{
    class Program
    {
        enum gender
        {
            female,
            male
        }

        enum orderState
        {
            payed,
            waitPay,
            deliver,
            complete
        }

        static void Main(string[] args)
        {
            gender gender = gender.male;
            Console.WriteLine(gender);
            Console.WriteLine((int)gender);
            gender = gender.female;
            Console.WriteLine(gender);
            Console.WriteLine((int)gender);
        }
    }
}

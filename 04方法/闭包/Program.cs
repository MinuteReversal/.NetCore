using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            Action f1 = () =>
            {
                var i2 = 2;
                Action f2 = () =>
                {
                    var i3 = 3;
                    Console.WriteLine($"{i}{i2}{i3}");
                };
                f2();
            };
            
            f1();
        }
    }
}

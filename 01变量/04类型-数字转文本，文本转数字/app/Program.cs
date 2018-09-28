using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 365;
            string s = "720";

            s = Convert.ToString(i);
            i = Convert.ToInt32(s);


            Console.WriteLine(i);
            Console.WriteLine(s);

        }
    }
}

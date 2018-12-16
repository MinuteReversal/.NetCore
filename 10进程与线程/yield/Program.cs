using System;

namespace yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Generator())
            {
                Console.WriteLine(i);
            }
        }

        static System.Collections.Generic.IEnumerable<int> Generator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }
    }
}

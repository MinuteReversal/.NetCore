using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] _1_100 = new int[100];//定义100个成员的数组

            //给数组的每一个成员赋值
            for (var i = 0; i < 100; i++)
            {                                     //索引0 1 2... 99
                _1_100[i] = i + 1;//将数组的成员内容设置为1,2,3...100
            }

            //访问数组的每一个成员
            foreach (int item in _1_100)
            {
                if (item % 2 == 0) sum += item;//偶数和
            }

            Console.WriteLine(sum);
        }
    }
}

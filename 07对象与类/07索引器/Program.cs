using System;

namespace 索引器
{
    class Program
    {
        public class Room
        {
            private string[] students = new string[44];
            public string this[int index]
            {
                get
                {
                    if (index > -1 && index < 44)
                    {
                        return students[index];
                    }
                    return "没有找到";
                }
                set
                {
                    if (index > -1 && index < 44)
                    {
                        students[index] = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("index");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var room = new Room();
            room[0] = "lily";
            room[1] = "lucy";
            room[2] = "hanmeimei";
            room[4] = "lilei";

            Console.WriteLine(room[99]);
            Console.WriteLine(room[1]);
        }
    }
}

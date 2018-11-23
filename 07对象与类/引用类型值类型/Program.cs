using System;
using System.Linq;

namespace 引用类型值类型
{
    struct StudentVal
    {
        public string Name;
    }
    class StudentRef
    {
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组成员为值类型
            var room1 = new StudentVal[]{
                new StudentVal{Name="lily"},
                new StudentVal{Name="lucy"},
                new StudentVal{Name="Lilei"},
                new StudentVal{Name="hanmeimei"}
            };
            for (int i = 0; i < room1.Length; i++)
            {
                var s = room1[i];
                s.Name = "hello";
            }
            Console.WriteLine(string.Join(",", room1.Select(x => x.Name)));
            #endregion

            #region  数组成员为引用类型
            var room2 = new StudentRef[]{
                new StudentRef{Name="lily"},
                new StudentRef{Name="lucy"},
                new StudentRef{Name="Lilei"},
                new StudentRef{Name="hanmeimei"}
            };

            for (int i = 0; i < room2.Length; i++)
            {
                var s = room2[i];
                s.Name = "hello";
            }
            Console.WriteLine(string.Join(",", room2.Select(x => x.Name)));
            #endregion
        }
    }
}

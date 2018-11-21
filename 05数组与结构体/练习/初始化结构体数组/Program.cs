using System;

namespace 初始化结构体数组
{

    struct Studnet
    {
        public string name;

        public char sex;

        public ulong birthday;

        public float height;

        public float weight;

    }

    class Program
    {
        static Studnet[] room = new Studnet[4]{
                new Studnet{ name="Zhy",sex='M',birthday=20011128,height=1.77f, weight=62f },
                new Studnet{ name="Lixing",sex='M',birthday=20011128,height=1.77f, weight=62f },
                new Studnet{ name="Helei",sex='M',birthday=20011128,height=1.77f, weight=62f },
                new Studnet{ name="ZhangMen",sex='M',birthday=20011128,height=1.77f, weight=62f }
            };
        static void Main(string[] args)
        {
            Console.WriteLine(room[0].name);
        }
    }
}

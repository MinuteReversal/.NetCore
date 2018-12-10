using System;

namespace 借刀杀人
{
    delegate void Nife(object target);//刀

    class Caocao
    {
        private string Name = "曹操";
        public override string ToString()
        {
            return this.Name;
        }
    }

    class Zhugeliang
    {
        private string Name = "诸葛亮";
        public Nife BorrowNife { get; set; }
    }

    class Machao
    {
        private string Name = "马超";
        public void Kill(object target)
        {
            Console.WriteLine($"{this.Name}杀了{target}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zhugeliang zhugeliang = new Zhugeliang();
            Machao machao = new Machao();
            Caocao caocao = new Caocao();

            zhugeliang.BorrowNife = machao.Kill;
            zhugeliang.BorrowNife(caocao);
        }
    }
}

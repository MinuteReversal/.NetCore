using System;

namespace 引用类型与值类型
{
    class R_Student
    {
        public string Name;

    }

    struct V_Student
    {
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            R_Student rs1 = new R_Student() { Name = "lilei" };
            R_Student rs2 = rs1;
            Console.WriteLine(rs1.Name);
            Console.WriteLine(rs2.Name);
            rs1.Name = "oldlilei";
            Console.WriteLine(rs1.Name);
            Console.WriteLine(rs2.Name);

            V_Student vs1 = new V_Student() { Name = "lilei" };
            V_Student vs2 = vs1;
            Console.WriteLine(vs1.Name);
            Console.WriteLine(vs2.Name);
            rs1.Name = "oldlilei";
            Console.WriteLine(vs1.Name);
            Console.WriteLine(vs2.Name);
        }
    }
}

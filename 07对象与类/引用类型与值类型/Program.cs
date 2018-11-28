using System;

namespace 引用类型与值类型
{
    //定义一个类：注意类是*引用类型*
    class R_Student
    {
        public string Name;

    }

    //定义一个结构体：注意结构体是*值类型*
    struct V_Student
    {
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("引用类型与值类型");
            V_Student vs1 = new V_Student() { Name = "lilei" };//初始化一个结构体并存入变量vs1
            V_Student vs2 = vs1;//把vs1的内容复制一份给vs2
            Console.WriteLine(vs1.Name);
            Console.WriteLine(vs2.Name);
            vs1.Name = "oldlilei";//
            Console.WriteLine(vs1.Name);
            Console.WriteLine(vs2.Name);
            Console.WriteLine("把值类型理解为普通变量。");
            Console.WriteLine("********华丽的分割线*******");
            R_Student rs1 = new R_Student() { Name = "lilei" };//创建一个快捷方式rs1并把其指向new R_Student() 语句创建出来的对象。
            R_Student rs2 = rs1;//创建一个快捷方式rs2并把其指向rs1指向的对象
            Console.WriteLine(rs1.Name);
            Console.WriteLine(rs2.Name);
            rs1.Name = "oldlilei";
            Console.WriteLine(rs1.Name);
            Console.WriteLine(rs2.Name);
            Console.WriteLine("可以把引用类型理解为windows 快捷方式");
            Console.WriteLine("********总结*******");
            Console.WriteLine("值类型互不影响，引用类型互相影响。");
        }
    }
}

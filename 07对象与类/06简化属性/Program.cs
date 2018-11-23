using System;

namespace _06简化属性
{
    class Student
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student[] soft1801 = new Student[]{
                new Student{Name="lily",Gender=0,Birthday=new DateTime(1985,1,1)},
                new Student{Name="lucy",Gender=0,Birthday=new DateTime(1985,1,1)},
                new Student{Name="lilei",Gender=1,Birthday=new DateTime(1985,1,1)}
            };

        }
    }
}

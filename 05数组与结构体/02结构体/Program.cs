using System;
using System.Collections.Generic;
using System.Drawing;

namespace 结构体
{
    class Program
    {

        struct Student
        {
            public static readonly Student Empty = new Student();//建议封装

            public string name;

            public int age;

            public int gender;

        }

        static void Main(string[] args)
        {
            //*************************需要对每个成员赋值*************************
            Student s1;
            s1.age = 31;
            
            s1.name = "lily";
            s1.gender = 0;

            Student s2 = Student.Empty;
            s2.age = 18;
            s2.name = "lucy";
            s2.gender = 0;

            Student s3 = new Student();
            s3.age = 22;
            s3.name = "lilei";
            s3.gender = 1;

            Console.WriteLine(s1.name);

            Student[] ss = { s1, s2, s3 };
            foreach (var student in ss)
            {
                Console.WriteLine($"姓名:{student.name},年龄:{student.age},性别:{(student.gender == 0 ? "女" : "男")}");
            }

            List<Student> ss1 = new List<Student>();
            ss1.Add(s1);
            ss1.Add(s2);
            ss1.Add(s3);

            ss1.Remove(s2);
            ss1.RemoveAt(2);

            ss1.Insert(1, s2);
        }
    }
}

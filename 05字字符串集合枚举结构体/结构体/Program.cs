using System;
using System.Collections.Generic;

namespace 结构体
{
    class Program
    {
        struct Student
        {
            public string name;

            public int age;

            public int gender;

        }

        static void Main(string[] args)
        {
            Student s;
            s.age = 31;
            s.name = "lily";
            s.gender = 0;

            Student s2 = new Student();
            s2.age = 18;
            s2.name = "lucy";
            s2.gender = 0;

            Student s3 = new Student();
            s3.age = 22;
            s3.name = "li lei";
            s3.gender = 1;

            Console.WriteLine(s.name);

            Student[] ss = { s, s2, s3 };
            foreach (var student in ss)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}

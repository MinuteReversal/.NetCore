/*
使用列表
添加一位同学成绩
删除一位同学成绩
修改一位同学成绩
查询一位99分的同学

 */
using System;
using System.Collections.Generic;

namespace 列表增删查改
{
    struct Student
    {
        public string Name;

        public int Score;

        public Student(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){
                new Student("lily",78),
                new Student("lucy",99 ),
                new Student("lilei",60)
            };

            //增加一位同学
            students.Add(new Student("hanmeimei", 86));

            //删除一位同学，填入索引号
            students.RemoveAt(0);

            //修改第2个同学的成员为61分
            Student student = students[1];
            student.Score = 61;

            Student search = students.Find(s => s.Score == 99);
            Console.WriteLine($"考99分的同学名字叫{search.Name}");
        }
    }
}

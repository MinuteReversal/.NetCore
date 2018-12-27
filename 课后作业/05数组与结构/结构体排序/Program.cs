/* 
*使用结构体数组添加三个学生,用年龄进行排序(大到小)
*/
using System;
namespace 结构体排序
{

    //学生结构体
    struct Student
    {
        public int Age;//年龄

        public string Name;//姓名

    }

    class Program
    {
        static void Main(string[] args)
        {   //学生结构体数组
            Student[] students = new Student[3]{
                new Student{ Name="lily",Age=18 },
                new Student{ Name="lucy",Age=22 },
                new Student{ Name="lilei",Age=21 }
            };
            //冒泡升序法
            for (int j = 0; j < students.Length; j++)
            {
                for (int i = 0; i < students.Length - 1; i++)
                {
                    //比较年龄
                    if (students[i].Age < students[i + 1].Age)
                    {
                        Student temp;
                        temp = students[i];
                        students[i] = students[i + 1];
                        students[i + 1] = temp;
                    }
                }
            }

            //输出成绩
            foreach (var s in students)
            {
                Console.WriteLine($"name:{s.Name},age:{s.Age}");
            }

        }
    }
}

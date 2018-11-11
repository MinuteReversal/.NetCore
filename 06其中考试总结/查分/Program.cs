using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace 查分
{
    class Program
    {
        struct Student
        {
            public string name; public double score1; public double score2; public double score3; public double score4; public double score5; public double score;
        }

        static Student[] soft1801 = new Student[44];//定义一个44个成员的数组

        static void Main(string[] args)
        {
            Console.WriteLine("欢迎进入分数查询系统");
            Console.WriteLine("加载数据中……");
            LoadData();
            Console.WriteLine("数据加载完成!");
            var inputName = "";
            do
            {
                Console.WriteLine("请输入姓名进行查询，若输入q则退出系统。");
                inputName = Console.ReadLine();
                FindByName(inputName);
            } while (inputName != "q");
            Console.WriteLine("退出系统。");
        }
        /* 加载数据 */
        static void LoadData()
        {
            string path = "./soft1801.csv";
            if (!File.Exists(path)) Console.WriteLine("没有找到数据文件，请联系老师。");
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                for (var i = 0; sr.Peek() >= 0; i++)
                {
                    var ts = sr.ReadLine().Split(",");
                    var ss = soft1801[i];
                    ss.name = NameToUnicode(ts[0]);
                    ss.score1 = double.Parse(ts[1]);
                    ss.score2 = double.Parse(ts[2]);
                    ss.score3 = double.Parse(ts[3]);
                    ss.score4 = double.Parse(ts[4]);
                    ss.score5 = double.Parse(ts[5]);
                    ss.score = ss.score1 +
                               ss.score2 +
                               ss.score3 +
                               ss.score4 +
                               ss.score5;
                    soft1801[i] = ss;
                }
            }
        }        /*\u字符转utf-8*/
        static string NameToUnicode(string name)
        {
            var nArray = name.Split("\\u");
            var realName = "";
            foreach (var c in nArray)
            {
                if (c == "") continue;
                realName += (char)Convert.ToInt32(c, 16);
            }
            return realName;
        }
        /*查询*/
        static void FindByName(string name)
        {
            foreach (var s in soft1801)
            {
                if (s.name.Contains(name))
                {
                    Console.WriteLine("姓名：" + s.name +
                                    ",选择题：" + s.score1 +
                                    "分,判断题:" + s.score3 +
                                    "分,填空题:" + s.score4 +
                                    "分,编程题:" + s.score5 +
                                    "分,总分:" + s.score +
                                    "分");
                    return;
                }
            }
            Console.WriteLine($"没有找到此同学{name}");
        }
    }
}

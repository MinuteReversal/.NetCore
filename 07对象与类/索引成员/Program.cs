using System;

namespace 索引成员
{
    class Student
    {
        private string Name;
        private string Gender;
        private string Bithday;
        private string No;

        public string this[string key]
        {
            set
            {
                switch (key.ToLower())
                {
                    case "name":
                        Name = value;
                        break;
                    case "gender":
                        Gender = value;
                        break;
                    case "bithday":
                        Bithday = value;
                        break;
                    case "no":
                        No = value;
                        break;
                    default:
                        Console.WriteLine($"设置{key}时没有找到成员");
                        break;
                }
            }
            get
            {
                switch (key.ToLower())
                {
                    case "name":
                        return Name;
                    case "gender":
                        return Gender;
                    case "bithday":
                        return Bithday;
                    case "no":
                        return No;
                    default:
                        Console.WriteLine($"获取{key}时没有找到成员");
                        return "";
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student();
            s["name"] = "lily";
            s["gender"] = "male";
            s["bithday"] = "1985-11-11";
            s["no"] = "1";

            Console.WriteLine($"name:{s["name"]},gender:{s["gender"]},bithday:{s["bithday"]},no:{s["no"]}");
        }
    }
}

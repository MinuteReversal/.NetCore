using System;

namespace 匿名
{
    class Program
    {
        static void Main(string[] args)
        {
            Action fn = delegate () { };//匿名方法
            object o = new { Name = "lily" };//匿名对象
        }
    }
}

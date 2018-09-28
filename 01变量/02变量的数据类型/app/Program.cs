using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义变量

            //值类型变量
            short st = 0;
            int i = 1;
            long l = 2;
            byte bt = 3;
            char c = '4';
            float f = 5;
            double d = 6;
            decimal dc = 7;
            bool b = true;


            /*
            * 以下为引用类型
            */
            string s = new string("hello world");
            string s1 = "My name is zhy";
            object o = new object();
            int[] list = new int[32];
            Action fn = () => { };
            Action<string[]> fn1 = Main;
            ICloneable ic = new String("hohoho");
        }
    }
}

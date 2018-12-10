using System;

namespace 记事本
{
    class Notepad
    {
        private string Content { get; set; }

        public string Open()
        {
            return this.Content;
        }

        public void Save(string content)
        {
            this.Content = content;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Notepad txt1 = new Notepad();
            Console.WriteLine(txt1.Open());
            txt1.Save("hello world");

            Notepad link1 = txt1;
            Notepad link2 = txt1;
            Notepad link3 = txt1;

            Console.WriteLine(txt1.Open());
            Console.WriteLine(link1.Open());
            Console.WriteLine(link2.Open());
            Console.WriteLine(link3.Open());

        }
    }
}

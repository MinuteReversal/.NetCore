using System;

namespace 符号重载
{
    //http://www.runoob.com/csharp/csharp-operator-overloading.html
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/operator
    class Box
    {
        private double Length { get; set; }      // 长度
        private double Width { get; set; }     // 宽度
        private double Height { get; set; }      // 高度

        public Box() { }
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double getVolume()
        {
            return Length * Width * Height;
        }

        public static Box operator +(Box d1, Box d2)
        {
            return new Box(
                d1.Length + d2.Length,
                d1.Width + d2.Width,
                d1.Height + d2.Height
            );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box(1, 2, 3);
            var box2 = new Box(4, 5, 6);
            var box3 = box1 + box2;
            Console.WriteLine($"box3体积是：{box3.getVolume()}");
        }
    }
}

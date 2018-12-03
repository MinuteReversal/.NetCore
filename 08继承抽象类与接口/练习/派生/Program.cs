using System;

namespace 派生
{

    /*形状抽象类 */
    abstract class AShape
    {
        /*获取面积 */
        public abstract void GetArea();
    }

    //方形
    class Square : AShape
    {
        public Square(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width { get; set; }//宽
        public int Height { get; set; }//高
        public override void GetArea()
        {
            Console.WriteLine($"方块的面积是{this.Width * this.Height}");
        }
    }

    //圆形
    class Circle : AShape
    {
        public double Radius { get; set; }//半径
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override void GetArea()
        {
            Console.WriteLine($"圆的面积是{ Math.PI * Math.Pow(this.Radius, 2.0) }");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AShape shape;                //声明一个AShape类型的变量
            shape = new Square(100, 200);//实例化一个方块，将引用shape指向它
            shape.GetArea();             //获取它的面积
            shape = new Circle(300.0);   //实例化一个圆，将引用shape指向它
            shape.GetArea();             //获取它的面积
        }
    }
}

using System;

namespace 汽车
{
    //类是设计图纸
    class Car//小汽车
    {
        public string Brand { get; set; }//品牌
        public string Color { get; set; }//颜色
        private string State { get; set; }//状态

        public Car(string brand, string Color)//有参数构造方法
        {
            this.Brand = brand;
            this.Color = Color;
        }
        public void Start()
        {
            this.State = "启动";
            Console.WriteLine($"一辆{this.Brand}牌子的{this.Color}颜色的小汽车{this.State}了");
        }
        public void Run()
        {
            this.State = "开走";
            Console.WriteLine($"一辆{this.Brand}牌子的{this.Color}颜色的小汽车{this.State}了");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "红色");//实例是按图纸生产出来的产品
            car1.Start();
            car1.Run();

            Car car2=new Car("保时捷","白色");//实例是按图纸生产出来的产品
            car2.Start();
            car2.Run();
        }
    }
}

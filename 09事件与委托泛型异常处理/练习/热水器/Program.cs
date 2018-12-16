using System;

namespace 热水器
{

    /*热水壶 */
    class Heater
    {
        private int temperature;//温度
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if ((temperature >= 0) && (temperature <= 100))
                {
                    temperature = value;
                }
                else
                {
                    Console.WriteLine("温度有问题！显示出错！");
                }
            }
        }
        public event EventHandler Alarm;//报警事件
        public event EventHandler Display;//显示事件

        //烧水
        public void BoilWater(int m)//m是分钟
        {
            Console.WriteLine("感谢您使用热水器，现在温度为{0}，\n本次烧水时间为{1}分钟。（每分钟提高10摄氏度）", this.temperature, m);
            this.temperature = m * 10 + this.temperature;//1次加10度
            if (this.temperature >= 100)
            {
                this.temperature = 100;
            }
            if (this.temperature >= 95)
            {
                //热水器是第一个参数，温度是第二个参数
                //把this装箱为object,把TemperatureEventArgs装箱为EventArgs
                Alarm(this, new TemperatureEventArgs(temperature));//触发警报事件
                Display(this, new TemperatureEventArgs(temperature));//触发显示事件
            }
            else
            {
                Console.WriteLine("目前还没有烧开！");
            }
        }
    }

    //水温度事件参数
    class TemperatureEventArgs : EventArgs
    {
        public TemperatureEventArgs(int t)//有参数构造器
        {
            this.Temperature = t;
        }
        public int Temperature { get; }//温度
    }
    //报警器
    class Alarm
    {
        //订阅警报
        public void MakeAlert(object sender, EventArgs args)
        {
            int temperature = ((TemperatureEventArgs)args).Temperature;//把args从EventArgs拆箱出来为TemperatureEventArgs
            Console.WriteLine("叮叮叮，叮叮叮……\n报警器提示水壶水温现在是{0}", temperature);
        }
    }
    //显示器
    class Display
    {
        public void ShowMsg(object sender, EventArgs args)
        {
            int temperature = ((TemperatureEventArgs)args).Temperature;//把args从EventArgs拆箱出来为TemperatureEventArgs
            Console.WriteLine("显示器提示现在的水温为{0}", temperature);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();   //拿来一个热水器heater.BoilWater(3);//再烧水3分钟
            heater.Temperature = 10;        //导入10度的水
            Alarm alarm = new Alarm();      //拿来一个报警器
            Display display = new Display();//拿来一个显示器
            heater.Alarm += alarm.MakeAlert;//把热水器和报警器连接起来
            heater.Display += display.ShowMsg;//把显示器和热水器连接起来
            heater.BoilWater(3);//烧水3分钟
            heater.BoilWater(3);//再烧水3分钟
            heater.BoilWater(3);//再烧水3分钟

        }
    }
}

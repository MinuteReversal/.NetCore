using System;

namespace 工厂模式
{

    //人类接口
    interface IHuman
    {
        void Talk();    //会说话
        void GetColor();//有肤色
    }

    //黑色人种类
    class BlackHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("黑色人种的皮肤是黑色的！");
        }

        public void Talk()
        {
            Console.WriteLine("黄色人类说话，一般人听不懂。");
        }
    }

    //黄色人种类
    class YellowHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("黄色人种的皮肤是黄色的！");
        }

        public void Talk()
        {
            Console.WriteLine("黄色人类说话，一般都是双字节。");
        }
    }

    //白色人种类
    class WhiteHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("白色人种的皮肤是白色的！");
        }

        public void Talk()
        {
            Console.WriteLine("白色人类说话，一般都是单字节。");
        }
    }

    //女娲的抽象八卦炉子
    abstract class AHumanFactory
    {
        //传入要求，返回练出来的人的
        public abstract IHuman CreateHuman(string className);
    }

    class HumanFactory : AHumanFactory
    {
        public override IHuman CreateHuman(string className)
        {
            switch (className)
            {
                case "bh":
                    return new BlackHuman();
                case "yh":
                    return new YellowHuman();
                case "wh":
                    return new WhiteHuman();
                default:
                    return null;

            }
        }
    }

    //女娲类
    class NvWa
    {
        static void Main(string[] args)
        {
            //实例化女娲的阴阳八卦炉
            AHumanFactory HumanFactory = new HumanFactory();
            //女娲第一次造人，火候不足，于是白人产生了
            IHuman whiteHuman = HumanFactory.CreateHuman("wh");
            whiteHuman.GetColor();
            whiteHuman.Talk();
            //女娲第二次造人，火候过足，于是黑人产生了
            IHuman blackHuman = HumanFactory.CreateHuman("bh");
            blackHuman.GetColor();
            blackHuman.Talk();
            //女娲第三次造人，火候刚好，于是黄种人产生了
            IHuman yellowHuman = HumanFactory.CreateHuman("yh");
            yellowHuman.GetColor();
            yellowHuman.Talk();
        }
    }
}

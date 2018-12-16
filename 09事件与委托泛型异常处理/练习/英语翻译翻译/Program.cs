using System;

namespace 英语翻译翻译
{

    delegate void DFn();//无参数无返回值方法的委托

    /*机器人*/
    class Droid
    {
        //机器人说二进制认也看不懂
        public DFn Say = BiliBili;//机器人说话的默认值是BiliBili这个方法

        //哔哩哔哩的说话
        static void BiliBili()
        {
            Console.WriteLine(
                            "100111101100000" +
                            "‭0101100101111101" +
                            "‭0101010101001010‬"
                        );
        }
    }

    /*英语翻译家*/
    class TranslatorEN
    {
        //说英文
        public void Say()
        {
            Console.WriteLine("How are you.");
        }
    }

    /*中文翻译家*/
    class TranslatorZhCN
    {
        //说中文
        public void Say()
        {
            Console.WriteLine("你好啊。");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Droid droid = new Droid();                           //实例化一个机器人
            TranslatorEN translatorEN = new TranslatorEN();      //实例化一个英文翻译家
            TranslatorZhCN translatorZhCN = new TranslatorZhCN();//实例化一个中文翻译家

            droid.Say();                    //机器人说话谁也听不懂
            droid.Say = translatorEN.Say;   //机器人向英文翻译家学习了说英语
            droid.Say();                    //机器人说话了
            droid.Say = translatorZhCN.Say; //机器人又向中文翻译家学习了说汉语
            droid.Say();                    //机器人说话了
        }
    }
}

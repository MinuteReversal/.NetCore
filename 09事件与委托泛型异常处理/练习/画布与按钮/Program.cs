using System;

namespace 画布与按钮
{

    /*
    *  展示里有一张画，画里面有一个按钮，用户点了按钮会显示一段文字。
     */

    //按钮 派发者
    class Button
    {
        //EventHandler是系统推荐的事件处理委托，也可以自己写
        public event EventHandler ButtonClick;//用户点击按钮事件
        public void Click()
        {
            ButtonClick(this, null);
        }
    }

    //画布 订阅者
    class Canvas
    {
        public Canvas(Button btn)
        {
            btn.ButtonClick += ShowPicture;
        }

        void ShowPicture(object sender, EventArgs e)
        {
            Console.WriteLine("我是一张画！现在显示出来了。");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();//创建一个按钮
            Canvas canvas = new Canvas(button);//创建一个画，并把按钮放到画里

            button.Click();//现在用户点了这个按钮
        }
    }
}

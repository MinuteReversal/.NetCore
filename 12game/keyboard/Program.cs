using System;
using System.Threading;

namespace keyboard
{
    class Program
    {
        static string key = "";//把按下的键盘按键内容保存在这个变量里面
        static void Main(string[] args)
        {
            Console.CursorVisible = false;//不显示终端里的光标
            Thread tShow = new Thread(Show);//展示按下的按键
            Thread tListen = new Thread(ListenKeyDown);//监测按键按下

            tShow.Start();//启动展示的线程
            tListen.Start();//启动监听的线程

            /*需要在终端中ctrl+c停止本示例 */
        }

        //监测按钮按下
        static void ListenKeyDown()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();//等待用户按下按键，ReadKey方法会暂停线程
                key = new string(keyInfo.KeyChar, 1);
            }
        }

        //展示用户按下的按键
        static void Show()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);//设置打印在终端的左上角的位置
                Console.WriteLine($"key:{key}");
            }
        }
    }
}

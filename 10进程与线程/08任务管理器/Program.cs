using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _05任务管理器
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("==================================");
            Console.WriteLine("欢迎来到自制任务管理器");
            while (input != "0")
            {
                Console.WriteLine(
                    "==================================\r\n" +
                    "请输入操作\r\n" +
                    "1、查看windows的全部进程\r\n" +
                    "2、通过名字启动一个进程\r\n" +
                    "3、启动记事本并输入内容\r\n" +
                    "4、结束一个进程\r\n" +
                    "0、退出"
                );
                Console.Write("请输入：");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        GetAll();
                        break;
                    case "2":
                        Start();
                        break;
                    case "3":
                        StartAndModifyNotePad();
                        break;
                    case "4":
                        End();
                        break;
                }
            }
        }

        static void GetAll()
        {
            var all = Process.GetProcesses();
            Console.WriteLine($"id\tname");
            foreach (var p in all)
            {
                Console.WriteLine($"{p.Id}\t{p.ProcessName}");
            }
        }

        static void Start()
        {
            Console.WriteLine(
                "请输入要启动的程序名称\r\n" +
                "记事本：notepad\r\n" +
                "画图：mspaint\r\n" +
                "计算器：calc"
            );
            Console.Write("请输入英文：");
            string input = Console.ReadLine();
            Process.Start(input);
        }

        //https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-findwindowexa
        [DllImport("user32.dll")]
        static extern IntPtr FindWindowExA(IntPtr hWndParent, IntPtr hWndChildAfter, string lpszClass, string lpszWindow);

        //https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-sendmessage
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, string lParam);

        static void StartAndModifyNotePad()
        {
            var notepad = Process.Start("notepad");
            notepad.WaitForInputIdle();
            var edit = FindWindowExA(notepad.MainWindowHandle, new IntPtr(0), "Edit", null);
            SendMessage(edit, 0x000c, 0, "Hello World");

        }

        static void End()
        {
            Console.WriteLine("请输入要结束的进程的id，输入c取消。");
            Console.Write("id:");
            var input = Console.ReadLine();
            if (input == "q") return;

            var id = int.Parse(input);
            var p = Process.GetProcessById(id);
            if (p != null)
            {
                p.Kill();
            }
        }
    }
}

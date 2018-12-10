using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _03修改记事本里的内容
{
    class Program
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        //https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-sendmessage
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        static void Main(string[] args)
        {
            Process notepad = Process.Start("notepad");
            notepad.WaitForInputIdle();
            var p = notepad.MainWindowHandle;
            Console.WriteLine(p);
            Process[] notepads = Process.GetProcessesByName("notepad");
            if (notepads.Length == 0) return;
            if (notepads[0] != null)
            {
                IntPtr child = FindWindowEx(p, new IntPtr(0), "Edit", null);
                Console.WriteLine(child);
                SendMessage(child, 0x000C, 0, "hello");
            }
        }
    }
}

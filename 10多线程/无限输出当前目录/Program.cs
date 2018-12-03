using System;
using System.Diagnostics;

namespace 无限输出当前目录
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = string.Empty;
            Console.ForegroundColor = ConsoleColor.Green;//修改前景色

            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c dir");//设置要启动的程序
            processStartInfo.RedirectStandardOutput = true;                           //转向标准输出
            processStartInfo.UseShellExecute = false;                                 //不使用壳执行

            Process process = Process.Start(processStartInfo);//启动程序
            using (var streamReader = process.StandardOutput)//获取启动的程序的输出内容
            {
                output = streamReader.ReadToEnd();
            }
            //无限输出
            while (true) Console.WriteLine(output);
        }
    }
}
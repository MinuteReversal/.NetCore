using System;
using System.Diagnostics;//引入进程的命名空间

namespace 向cmd输入命令
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = string.Empty;
            Console.ForegroundColor = ConsoleColor.Green;//修改终端的输出前景色为绿色
                                                        //设置要启动的程序 启动后输入dir命令
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c dir");//输出当前运行程序的文件夹下的所有文件和文件夹
            processStartInfo.RedirectStandardOutput = true;                           //转向标准输出
            processStartInfo.UseShellExecute = false;                                 //不使用壳执行

            Process process = Process.Start(processStartInfo);//启动程序获取它的进程
            
            using (var streamReader = process.StandardOutput)//从进程中获取启动的程序的输出内容
            {
                output = streamReader.ReadToEnd();//读取cmd的返回内容存入output变量中
            }
            Console.WriteLine(output);//输出cmd的返回内容
        }
    }
}

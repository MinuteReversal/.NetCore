using System;
using System.Diagnostics;
using System.IO;

namespace 无限输出当前目录
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;
            string error = string.Empty;

            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c dir");
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);
            using (StreamReader streamReader = process.StandardOutput)
            {
                output = streamReader.ReadToEnd();
            }
            //无限输出
            for (; ; ) Console.WriteLine(output);
        }
    }
}
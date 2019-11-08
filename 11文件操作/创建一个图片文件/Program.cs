/*
*需要安装 System.Drawing.Common
*终端里输入 dotnet add package System.Drawing.Common
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace 创建一个图片文件
{
    class Program
    {
        static void Main(string[] args)
        {            
            Bitmap bitmap = new Bitmap(100, 100);
            for (var x = 0; x < 100; x++)
            {
                for (var y = 0; y < 100; y++)
                {
                    if (y % 2 == 0)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));//白色
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(0xFF, 0xFF, 0x00, 0x00));//红色
                    }

                }
            }
            bitmap.Save("1.bmp", ImageFormat.Bmp);
        }
    }
}

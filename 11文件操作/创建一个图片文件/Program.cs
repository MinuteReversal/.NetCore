using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
//需要安装dotnet add package System.Drawing.Common

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
                    bitmap.SetPixel(x, y, Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
                }
            }
            bitmap.Save("1.bmp", ImageFormat.Bmp);
        }
    }
}

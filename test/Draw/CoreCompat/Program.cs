using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CoreCompat
{
    class Program
    {
        static void Main(string[] args)
        {
            //dotnet add package System.Drawing.Common --version 4.5.1
            /*
            *https://www.nuget.org/packages/System.Drawing.Common
            */
            var st = new MemoryStream();
            var bm = new Bitmap(300, 300);
            for (var x = 0; x < 300; x++)
            {
                for (var y = 0; y < 300; y++)
                {
                    bm.SetPixel(x, y, Color.FromArgb(50, 255, 0, 0));
                }
            }
            bm.Save("1.bmp", ImageFormat.Bmp);
        }
    }
}

/*
* 需要联网安装 System.Drawing.Common
* ctrl+~ 终端里输入 dotnet add package System.Drawing.Common
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace 在图片上写文字
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(200, 200);//创建200像素x200像素的图片
            Graphics g = Graphics.FromImage(bitmap);//使用图像处理类(Graphics)加载这张图片            

            // 在图片上绘制的内容
            string drawString = "2019年元旦要到了";

            // 创建字体和画刷
            Font drawFont = new Font("微软雅黑", 12);//字体 微软雅黑，12像素大小
            SolidBrush drawBrush = new SolidBrush(Color.White);//画刷颜色白色

            // 在绘制目标的左上角绘制
            float x = 10.0F;//位置
            float y = 10.0F;//位置

            // 设置文字书写格式
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DisplayFormatControl;//绘制方向横向

            // 把文字绘制到图片上            
            g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            g.DrawString("祝大家元旦快乐", drawFont, drawBrush, x, y + 20, drawFormat);
            bitmap.Save("1.jpg", ImageFormat.Jpeg);//保存图片为文件，格式为jpg
        }
    }
}

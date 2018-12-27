/*
* 需要联网安装 System.Drawing.Common
* ctrl+~ 终端里输入 dotnet add package System.Drawing.Common
*                  ⬆      ⬆   ⬆
*                小写    小写 小写
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace 在图片上画一张笑脸
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一张200像素X200像素的图片
            Bitmap bitmap = new Bitmap(200, 200);

            /* 用图像处理类加载这个图片 */
            Graphics g = Graphics.FromImage(bitmap);

            //创建一个笔,颜色白色，宽度为2个像素
            Pen pen = new Pen(Color.White, 2);

            /* 创建一个矩形，左上角为位置为0，0，宽度200，高度200，正好和图片一样大小 */
            Rectangle rectangle = new Rectangle(0, 0, 200, 200);//画脸的位置

            //https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics.drawarc?view=netframework-4.7.2
            //画一个弧线（笔，位置，开始角度，范围）
            g.DrawArc(pen, rectangle, 0, 360);//从 x 轴到弧线的起始点沿顺时针方向度量的角

            //左边眼睛位置
            Rectangle leftEye = new Rectangle(30, 40, 60, 60);
            //画一个弧线（笔，位置，开始角度，范围）
            g.DrawArc(pen, leftEye, 0, -180);

            //右边眼睛位置
            Rectangle rightEye = new Rectangle(110, 40, 60, 60);
            //画一个弧线（笔，位置，开始角度，范围）
            g.DrawArc(pen, rightEye, 0, -180);

            Rectangle mouth = new Rectangle(60, 90, 80, 80);
            //画一个弧线（笔，位置，开始角度，范围）
            g.DrawArc(pen, mouth, 0, 180);

            bitmap.Save("1.png", ImageFormat.Png);
        }
    }
}

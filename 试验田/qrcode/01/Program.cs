/*
* 需要联网安装 QRCoder 二维码生成程序集，和图程序集，方法如下
* Ctrl+~ 在终端里输入 dotnet add package System.Drawing.Common 回车
* Ctrl+~ 在终端里输入 dotnet add package QRCoder 回车
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                参考资料：
                    https://baike.baidu.com/item/QR二维码/7414523
                    https://github.com/codebude/QRCoder/

                二维码的内容，如果想让手机扫描后跳转网址，那么内容要以http://开头
                例如：http://www.baidu.com
            */
            string content = "祝大家期末考试顺利！";//这里填写二维码的内容

            QRCodeGenerator qr = new QRCodeGenerator();//实例化二维码(QRCode)生成器

            //对二维码生成器设置                      内容 和              容错质量            
            QRCodeData qRCodeData = qr.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);     //通过设置生成二维码实例        
            Bitmap qrcodeImage = qRCode.GetGraphic(20); //把二维码写入图片中

            /*把二维码保存在程序目录下名字叫 码.gif，图片类型为 位图gif*/
            qrcodeImage.Save("码.gif", ImageFormat.Gif);
        }
    }
}

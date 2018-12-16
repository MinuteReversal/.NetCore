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
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData qRCodeData = qr.CreateQrCode("http://www.baidu.com", QRCodeGenerator.ECCLevel.Q);            
            QRCode qRCode = new QRCode(qRCodeData);            
            Bitmap qrcodeImage = qRCode.GetGraphic(20);
            qrcodeImage.Save("qrcode", ImageFormat.Bmp);
        }
    }
}

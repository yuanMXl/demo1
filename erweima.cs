using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using ZXing;
using ZXing.QrCode;

namespace demo
{
    public class erweima
    {
        public static void Generate(string text)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            options.CharacterSet = "UTF-8";
            options.Width = 300;
            options.Height = 300;
            options.Margin = 1;
            writer.Options = options;
            Bitmap map = writer.Write(text);
            string filename = @"C:\Users\Administrator\source\repos\demo\demo\img\qr.png";
            map.Save(filename, ImageFormat.Png);
            map.Dispose();
        }
    }
}
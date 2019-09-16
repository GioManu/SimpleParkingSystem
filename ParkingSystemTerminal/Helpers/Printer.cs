using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace ParkingSystemTerminal.Helpers {
    class Printer {
        public PrinterSettings pSettings { get; set; }
        
        public static void SendToPrint(BarCode barcode)
        {
            //Bitmap qrCode = GenerateQR(barcode);
            Bitmap qrCode = GenerateQR(barcode);
            Bitmap header = GenerateHeader(barcode);
            PrintImage(qrCode);
        }

        public static Bitmap GenerateHeader(BarCode barcode)
        {
            // TODO generate normal img
            Bitmap header = new Bitmap(50, 50);

            RectangleF rectf = new RectangleF(70, 90, 90, 50);

            Graphics g = Graphics.FromImage(header);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString($"მანქანის ნომერი : {barcode.CarNum} \n შემოსვლის თარიღი {barcode.StartDate.ToString()}", new Font("Arial", 10), Brushes.White, rectf);
            g.Flush();

            header.Save("C:\\IMAGE2.jpg", ImageFormat.Jpeg);
            return header;
        }

        public static Bitmap GenerateQR(BarCode barcode)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(barcode.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(appSettings.Default.QRCodeSize); // generated qrCode
            
            return qrCodeImage;
        }

        public static void PrintImage(Bitmap img)
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (object o, PrintPageEventArgs e) =>
            {
                Image i = Image.FromFile("C:\\IMAGE.jpg");
                Point loc = new Point(4, 4);
                e.Graphics.DrawImage(i, 10, 10, i.Width, i.Height);
            };

            pd.DefaultPageSettings.PaperSize = new PaperSize("80 x 80", appSettings.Default.PrinterPageSizeW, appSettings.Default.PrinterPageSizeH);
            
            pd.Print();
        }
        
    }
}

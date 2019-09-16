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
            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Image bcimg = brCode.Draw(barcode.StartDate.ToString(),100);

            GenerateImage(barcode,bcimg);

        }

        public static void GenerateImage(BarCode bar,Image bCode)
        {
            int x = 0;
            int y = 0;
            
            Font font = new Font("Arial", 10);

            Bitmap bmp = new Bitmap(height: 600, width: 302);

            using(Graphics g = Graphics.FromImage(bmp))
            {

                g.Clear(Color.White);

                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                Rectangle rc;

                for (int i = 0; i < 2; i++)
                {
                    rc = new Rectangle(x, y, 302, 20);
                    g.FillRectangle(Brushes.White, rc);
                    g.DrawString($"მანქანის ნომერი : {bar.CarNum}", font, Brushes.Black, rc);

                    y += 20;
                }
                rc = new Rectangle(x, y, 302, 20);
                g.FillRectangle(Brushes.White, rc);
                g.DrawImage(bCode, rc);

                g.Flush();
                
            }
            bmp.Save(appSettings.Default.TicketFile, ImageFormat.Jpeg);
        }


        //public static Bitmap GenerateQR(BarCode barcode)
        //{
        //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(barcode.ToString(), QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(qrCodeData);
        //    Bitmap qrCodeImage = qrCode.GetGraphic(appSettings.Default.QRCodeSize); // generated qrCode

        //    return qrCodeImage;
        //}
    }
}

using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace ParkingSystemTerminal.Helpers {
    class Ticket { 

        public string CarNum { get; set; }
        public DateTime StartDate { get; set; }
        public Bitmap QRCode { get; set; }
        public Int32 startDateInMinutes { get; set; }
        public string Header { get; set; }

        public Ticket(string carnum,DateTime startdate,string header)
        {
            this.CarNum = carnum;
            this.StartDate = startdate;
            this.Header = header;
            this.startDateInMinutes = Convert.ToInt32(startdate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalMinutes);
            this.QRCode = this.GenerateQRCode();
        }

        public override string ToString()
        {
            return $"CarNum : {this.CarNum} , StartDate : {this.StartDate.ToString()}";
        }

        private Bitmap GenerateQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(this.startDateInMinutes.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(appSettings.Default.QRCodeSize);
            
            return qrCodeImage;
        }

        private Image GenerateBarCode()
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

            var barcodeImage = barcode.Draw("2124978157", 50);

            var resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 20);

            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new Font("Consolas", 10))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(barcodeImage, 0, 0);
                graphics.DrawString("2124978157", font, brush, resultImage.Width / 2, resultImage.Height, format);
            }

            return resultImage;

        }
    }
}

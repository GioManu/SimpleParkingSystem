using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;

namespace ParkingSystemTerminal.Helpers {
    class Printer {
        
        public static void SendToPrint(Ticket ticket)
        {
            Image TicketImg = GenerateImage(ticket);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (object o, PrintPageEventArgs e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                e.Graphics.DrawImage(TicketImg, 0, 0);
            };
            pd.Print();
        }

        public static Image GenerateImage(Ticket ticket)
        {
            int x = 0;
            int y = 0;

            int bitHeight = 302;
            int bitWidth = 302;

            Font HeaderFont = new Font("Arial", 18, FontStyle.Regular);
            Font LabelFont = new Font("Arial", 16, FontStyle.Regular);
            Font DataFont = new Font("Arial", 14, FontStyle.Bold);

            x = Convert.ToInt32(bitWidth / 2 - (HeaderFont.SizeInPoints * appSettings.Default.Header.Length / 2)) - 20; 

            Bitmap bmp = new Bitmap(bitWidth, bitHeight);

            using(Graphics g = Graphics.FromImage(bmp))
            {
                Rectangle rc;
                g.Clear(Color.White);

                //g.SmoothingMode = SmoothingMode.HighQuality;
                //g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                //g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                
                rc = new Rectangle(x, y, 302, Convert.ToInt32(HeaderFont.Size) + 30);
                g.FillRectangle(Brushes.White, rc);
                g.DrawString(appSettings.Default.Header, HeaderFont, Brushes.Black, rc);

                y += Convert.ToInt32(HeaderFont.Size) + 20;
                x = 50;

                rc = new Rectangle(x, y, 302, Convert.ToInt32(LabelFont.Size) + 30);
                g.FillRectangle(Brushes.White, rc);
                g.DrawString("მანქანის ნომერი", LabelFont, Brushes.Black, rc);

                y += Convert.ToInt32(LabelFont.Size) + 10;
                

                rc = new Rectangle(x, y, 302, Convert.ToInt32(DataFont.Size) + 30);
                g.FillRectangle(Brushes.White, rc);
                g.DrawString(ticket.CarNum, DataFont, Brushes.Black, rc);

                y += Convert.ToInt32(DataFont.Size) + 10;


                rc = new Rectangle(x, y, 302, Convert.ToInt32(LabelFont.Size)+30);
                g.FillRectangle(Brushes.White, rc);
                g.DrawString("თარიღი", LabelFont, Brushes.Black, rc);

                y += Convert.ToInt32(LabelFont.Size) + 10;


                rc = new Rectangle(x, y, 302, Convert.ToInt32(DataFont.Size) + 30);
                g.FillRectangle(Brushes.White, rc);
                g.DrawString(ticket.StartDate.ToString(appSettings.Default.TicketDateFormat), DataFont, Brushes.Black, rc);

                y += Convert.ToInt32(DataFont.Size) + 10;

                x = 40;
                rc = new Rectangle(x, y, appSettings.Default.QRCodeSize * 40, appSettings.Default.QRCodeSize * 40);
                g.FillRectangle(Brushes.White, rc);
                g.DrawImage(ticket.QRCode, rc);

                g.Flush();
                
            }

            bmp.Save(appSettings.Default.TicketFile, ImageFormat.Jpeg);
            return bmp;
        }

    }
}

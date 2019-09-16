using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace ParkingSystemTerminal.Helpers {
     class Scanner {

        public Control btn { get; set; }
        public IListUpdater form { get; set; }
        public System.Timers.Timer timer { get; set; }
        

        public Scanner(IListUpdater form,Control scanBtn)
        {
            this.form = form;
            this.btn = scanBtn;
            this.timer = new System.Timers.Timer();
            this.timer.Elapsed += this.Scanning;
        }
        public void start()
        {
            this.btn.BackColor = Color.FromArgb(128, 128, 255);
            this.timer.Interval = 400;
            this.timer.Enabled = true;
        }
        public void stop()
        {
            this.form.resetControl();
            this.btn.BackColor = Color.SkyBlue;
            this.timer.Enabled = false;
        }
        public void Scanning(Object source, System.Timers.ElapsedEventArgs e)
        {
            this.form.checkInput();
        }

    }
}

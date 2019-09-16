using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingSystemTerminal.Helpers {
    class DateListener {
        public System.Timers.Timer timer { get; set; }

        public DateListener(long interval)
        {
            this.timer = new System.Timers.Timer();
            this.timer.Interval = interval;
            this.timer.Elapsed += this.Listening;
        }

        public void start()
        {
            this.timer.Enabled = true;
        }

        public void stop()
        {
            this.timer.Enabled = false;
        }

        public void Listening(Object source, System.Timers.ElapsedEventArgs e)
        {
            DateTimeChanger.CheckDateTime();
        }
    }
}

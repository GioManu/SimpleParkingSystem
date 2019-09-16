using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingSystemTerminal.Helpers {
    class BarCode { 

        public string CarNum { get; set; }
        public DateTime StartDate { get; set; }

        public BarCode(string carnum,DateTime startdate)
        {
            this.CarNum = carnum;
            this.StartDate = startdate;
        }

        public override string ToString()
        {
            return $"{this.CarNum}###{this.StartDate.ToString()}";
        }
    }
}

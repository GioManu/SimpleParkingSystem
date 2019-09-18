using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingSystemTerminal.Helpers {
    class Calculator {

        public static double CalculateDiff(Int32 mins)
        {
            double res;
            Int32 minutesNow = Convert.ToInt32(DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalMinutes);
            res = minutesNow - mins;
            return res;
        }
    }
}

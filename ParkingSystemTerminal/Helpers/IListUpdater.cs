using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystemTerminal.Helpers {
    interface IListUpdater {
        void updateList(string text);
        void checkInput();
        void resetControl();
    }
}

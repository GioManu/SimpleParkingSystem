using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystemTerminal {
    public partial class Settings : Form {
        public Form1 form;

        public Settings(Form1 parent)
        {
            InitializeComponent();
            this.form = parent;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        public void readSettings()
        {

        }
    }
}

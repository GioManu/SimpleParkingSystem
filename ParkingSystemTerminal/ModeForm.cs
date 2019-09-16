using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ParkingSystemTerminal {
    public partial class ModeForm : Form {
        private Form1 form;

        public ModeForm(Form1 parent)
        {
            InitializeComponent();
            this.form = parent;
        }

        private void ModeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setMode(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMode(1);
        }

        private void setMode(int mode)
        {

            File.Create(appSettings.Default.ModeFile).Dispose();

            using (var tw = new StreamWriter(appSettings.Default.ModeFile, true))
            {
                tw.WriteLine(mode.ToString());

            }
            this.form.allowshowdisplay = true;
            this.form.setMode(mode);
            this.form.Show();
            
            this.Close();
        }


    }
}

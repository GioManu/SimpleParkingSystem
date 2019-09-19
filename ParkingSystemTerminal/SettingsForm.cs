using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (this.form.panel1.Visible)
            {
                this.panel2.Visible = false;
                this.panel1.Visible = true;
            }
            else
            {
                this.panel2.Visible = true;
                this.panel1.Visible = false;
            }
            this.HeaderText.Text = this.form.ticketHeader;
            this.TariffText.Text = this.form.tariff.ToString();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        public static void SaveSettings(string tariff,string header)
        {
            File.Create($"{AppDomain.CurrentDomain.BaseDirectory}{appSettings.Default.SettingsFile}").Dispose();

            using (var tw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}{appSettings.Default.SettingsFile}", true))
            {
                tw.WriteLine(tariff);
                tw.WriteLine(header);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.form.tariff != Convert.ToDouble(TariffText.Text) || this.form.ticketHeader != HeaderText.Text)
            {
                if(Convert.ToDouble(TariffText.Text) <= 0)
                {
                    TariffText.Text = "1";
                }

                SaveSettings(TariffText.Text, HeaderText.Text);
                this.form.readSettings();
                this.form.settingsForm = null;
                this.Close();
            }
            else
            {
                this.form.settingsForm = null;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.form.settingsForm = null;
            this.Close();
        }
    }
}

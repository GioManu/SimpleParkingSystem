using ParkingSystemTerminal.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ParkingSystemTerminal {
    public partial class Form1 : Form {
        private int curVal = 0;
        private Control curControl;
        
        private bool validProcessing =false;

        public bool isScanning = false;

        private Scanner scanner;
        private delegate void EnableDelegate();

        private DateListener dateChecker;

        private ModeForm modeForm;
        public bool allowshowdisplay = true;

        public double tariff;
        public string ticketHeader;

        public Settings settingsForm;

        public Form1()
        {
            InitializeComponent();
            scanner = new Scanner(this, button1);
            dateChecker = new DateListener(10000);
            dateChecker.start();
            this.readSettings();
            this.modeForm = new ModeForm(this);
            this.GetMode();
            this.Tariff.KeyPress += this.Tariff_KeyPress;
            
        }

        private void PrintTicket_Click(object sender, EventArgs e)
        {
            var isValid = CheckInput(CarNum, (el) => el.Length >= 3);
            if (isValid)
            {
                Ticket ticket = new Ticket(CarNum.Text, DateTime.Now,this.ticketHeader);
                Printer.SendToPrint(ticket);
            }
        }

        private bool CheckInput(Control control, Func<string, bool> selector)
        {
            if (selector(control.Text))
            {
                return true;
            }
            else
            {
                if (!validProcessing)
                {
                    validProcessing = true;
                    control.BackColor = Color.FromArgb(255, 0, 0);
                    this.curControl = control;
                    validTimer.Interval = 30;
                    validTimer.Enabled = true;
                }

                return false;
            }
        }

        private void validTimer_Tick(object sender, EventArgs e)
        {
            curVal += 10;
            if(curVal >= 255)
            {
                curVal = 0;
                validProcessing = false;
                validTimer.Enabled = false;
            }
            else
            {
                curControl.BackColor = Color.FromArgb(255, curVal, curVal);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clearInputs();
            if (this.scanner.timer.Enabled) this.scanner.stop();
            else this.scanner.start();
        }
        

        public void checkInput()
        {
            if (InvokeRequired)
            {
                this.Invoke(new EnableDelegate(checkInput));
                return;
            }
            this.scanText.Focus();
            focusEfect(this.scanText, Color.FromArgb(255, 128, 128));
            if (this.scanText.Text.Length > 0)
            {
                try
                {
                    Int32 totalMinutes = Convert.ToInt32(this.scanText.Text);
                    double res = Calculator.CalculateDiff(totalMinutes);
                    this.ShowResult(res, totalMinutes);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print(ex.Message);
                }
                finally
                {
                    this.scanText.Clear();
                }

            }

        }

        public void focusEfect(Control ctrl,Color state)
        {
            ctrl.Focus();
            
            if (ctrl.BackColor == Color.White)
            {
                ctrl.BackColor = state;
            }
            else
            {
                ctrl.BackColor = Color.White;
            }
        }

        public void resetControl()
        {
            scanText.BackColor = Color.White;
            scanText.Text = String.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
        }

        public void setMode(int mode)
        {
            if (mode.Equals(0))
            {
                this.panel1.Visible = false;
                this.PrintContainer.Visible = true;
            }
            else
            {
                this.PrintContainer.Visible = false;
                this.panel1.Visible = true;
            }

        }
        public void GetMode()
        {
            try
            {
                using (StreamReader sr = new StreamReader(appSettings.Default.ModeFile))
                {
                    String line = sr.ReadLine();
                    int mode;
                    bool readMode = Int32.TryParse(line, out mode);
                    if (readMode)
                    {
                        if (mode.Equals(0) || mode.Equals(1))
                        {
                            this.setMode(mode);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

            }
            catch (Exception ex)
            {
                this.allowshowdisplay = false;
                this.modeForm.Show();
            }
        }
        
        private void ShowResult(double mins,Int32 totalMinutes)
        {
            TimeSpan tmp = TimeSpan.FromMinutes(mins);
            DateTime stDate = new DateTime(1970,1,1).AddMinutes(totalMinutes);

            if(DateTime.Now.Year - stDate.Year <= 1)
            {
                focusEfect(this.scanText, Color.FromArgb(128, 255, 128));

                double minsInHours = Math.Round((mins / 60), 2);
                //string workHours = string.Format("{0:00}:{1:00}", (int)tmp.TotalHours, tmp.Minutes);
                string workHours = tmp.TotalMinutes.ToString();
                this.ticketDate.Text = stDate.ToString("dd/MM/yyyy HH:mm");
                this.todayDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                this.SpentHours.Text = $"{workHours} წუთი";
                this.CostSum.Text = $"{(Math.Round(minsInHours * this.tariff, 2, MidpointRounding.ToEven)).ToString()} ლ";
                this.scanner.stop();
            }

        }

        private void clearInputs()
        {
            this.ticketDate.Clear();
            this.todayDate.Clear();
            this.scanText.Clear();
            this.SpentHours.Clear();
            this.CostSum.Clear();

        }

        public void readSettings()
        {
            try
            {
                using (StreamReader sr = new StreamReader(appSettings.Default.SettingsFile))
                {
                    String line = sr.ReadLine();
                    this.tariff = Convert.ToDouble(line);
                    this.Tariff.Text = this.tariff.ToString();
                    line = sr.ReadLine();
                    this.ticketHeader = line.Trim();
                }
            }
            catch(Exception ex)
            {
                Settings.SaveSettings("1", " ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.modeForm = new ModeForm(this);
            this.modeForm.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            if (settingsForm is null)
            {
                settingsForm = new Settings(this);
                settingsForm.Show();
            }
            else
            {
                settingsForm.Focus();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.Tariff.Text.Length > 0)
            {
                this.tariff = Convert.ToDouble(this.Tariff.Text);
                Settings.SaveSettings(this.tariff.ToString(), this.ticketHeader);
                this.readSettings();

            }
        }

        private void Tariff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}

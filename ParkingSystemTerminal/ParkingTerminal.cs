using ParkingSystemTerminal.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ParkingSystemTerminal {
    public partial class Form1 : Form ,IListUpdater{
        private int curVal = 0;
        private Control curControl;
        
        private bool validProcessing =false;
        public bool isScanning = false;

        private Scanner scanner;
        private delegate void EnableDelegate();

        private DateListener dateChecker;

        private ModeForm modeForm;

        public bool allowshowdisplay = true;

        public Form1()
        {
            InitializeComponent();
            scanner = new Scanner(this, button1);
            dateChecker = new DateListener(10000);
            dateChecker.start();

            this.modeForm = new ModeForm(this);
            this.GetMode();
        }

        private void PrintTicket_Click(object sender, EventArgs e)
        {
            var isValid = CheckInput(CarNum, (el) => el.Length >= 3);
            if (isValid)
            {
                BarCode barcode = new BarCode(CarNum.Text, DateTime.Now);
                Printer.SendToPrint(barcode);
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
            if (this.scanner.timer.Enabled)
            {
                this.scanner.stop();
            }
            else
            {
                this.scanner.start();
            }
        }

        public void updateList(string text)
        {
            this.myList.Items.Add(text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void checkInput()
        {
            if (InvokeRequired)
            {
                this.Invoke(new EnableDelegate(checkInput));
                return;
            }

            focusEfect(this.scanText);

            if (this.scanText.Text.Length > 0)
            {
                this.updateList(scanText.Text);
            }
        }

        public void focusEfect(Control ctrl)
        {
            ctrl.Focus();
            
            if (ctrl.BackColor == Color.White)
            {
                ctrl.BackColor = Color.FromArgb(255, 128, 128);
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
                this.PrintContainer.Visible = true;
            }
            else
            {
                this.panel1.Visible = true;
            }

        }
        public void GetMode()
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\ParkMode.ini"))
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
    }
}

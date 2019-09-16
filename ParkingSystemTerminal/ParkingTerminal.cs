using ParkingSystemTerminal.Helpers;
using System;
using System.Drawing;
using System.IO;
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

        public Form1()
        {
            InitializeComponent();
            scanner = new Scanner(this, button1);
            dateChecker = new DateListener(10000);
            dateChecker.start();
            GetMode();
        }

        private void PrintTicket_Click(object sender, EventArgs e)
        {
            var isValid = CheckInput(CarNum, (el) => el.Length >= 5);
            if (isValid)
            {
                //TODO: sendToPrinter
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetMode()
        {
            if (!File.Exists(appSettings.Default.ModeFile))
            {
                // Open Form and ask
            }
            else
            {
                try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(appSettings.Default.ModeFile))
                    {
                        String line = sr.ReadLine();
                        MessageBox.Show(line);
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }
    }
}

namespace ParkingSystemTerminal {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PrintContainer = new System.Windows.Forms.Panel();
            this.PrintTicket = new System.Windows.Forms.Button();
            this.CarNum = new System.Windows.Forms.TextBox();
            this.CarNumLabel = new System.Windows.Forms.Label();
            this.validTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.myList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scanText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintContainer
            // 
            this.PrintContainer.Controls.Add(this.PrintTicket);
            this.PrintContainer.Controls.Add(this.CarNum);
            this.PrintContainer.Controls.Add(this.CarNumLabel);
            this.PrintContainer.Location = new System.Drawing.Point(12, 12);
            this.PrintContainer.Name = "PrintContainer";
            this.PrintContainer.Size = new System.Drawing.Size(384, 251);
            this.PrintContainer.TabIndex = 1;
            // 
            // PrintTicket
            // 
            this.PrintTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PrintTicket.Location = new System.Drawing.Point(18, 158);
            this.PrintTicket.Name = "PrintTicket";
            this.PrintTicket.Size = new System.Drawing.Size(343, 59);
            this.PrintTicket.TabIndex = 3;
            this.PrintTicket.Text = "ბილეთის ბეჯდვა";
            this.PrintTicket.UseVisualStyleBackColor = true;
            this.PrintTicket.Click += new System.EventHandler(this.PrintTicket_Click);
            // 
            // CarNum
            // 
            this.CarNum.AccessibleName = "";
            this.CarNum.BackColor = System.Drawing.Color.White;
            this.CarNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CarNum.Location = new System.Drawing.Point(18, 78);
            this.CarNum.Name = "CarNum";
            this.CarNum.Size = new System.Drawing.Size(343, 53);
            this.CarNum.TabIndex = 2;
            // 
            // CarNumLabel
            // 
            this.CarNumLabel.AutoSize = true;
            this.CarNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CarNumLabel.Location = new System.Drawing.Point(12, 19);
            this.CarNumLabel.Name = "CarNumLabel";
            this.CarNumLabel.Size = new System.Drawing.Size(349, 46);
            this.CarNumLabel.TabIndex = 0;
            this.CarNumLabel.Text = "მანქანის ნომერი";
            // 
            // validTimer
            // 
            this.validTimer.Tick += new System.EventHandler(this.validTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.myList);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.scanText);
            this.panel1.Location = new System.Drawing.Point(408, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 455);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // myList
            // 
            this.myList.FormattingEnabled = true;
            this.myList.ItemHeight = 16;
            this.myList.Location = new System.Drawing.Point(12, 377);
            this.myList.Name = "myList";
            this.myList.Size = new System.Drawing.Size(514, 52);
            this.myList.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 105);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scanText
            // 
            this.scanText.AccessibleName = "";
            this.scanText.BackColor = System.Drawing.Color.White;
            this.scanText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.scanText.Location = new System.Drawing.Point(166, 18);
            this.scanText.Name = "scanText";
            this.scanText.Size = new System.Drawing.Size(343, 53);
            this.scanText.TabIndex = 5;
            this.scanText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ტარიფი";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ტარიფი";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PrintContainer);
            this.Name = "Form1";
            this.Text = "c";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PrintContainer.ResumeLayout(false);
            this.PrintContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PrintContainer;
        private System.Windows.Forms.Label CarNumLabel;
        public System.Windows.Forms.TextBox CarNum;
        private System.Windows.Forms.Button PrintTicket;
        private System.Windows.Forms.Timer validTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox scanText;
        public System.Windows.Forms.ListBox myList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


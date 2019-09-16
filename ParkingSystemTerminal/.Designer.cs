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
            this.label2 = new System.Windows.Forms.Label();
            this.myList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scanText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CarInput = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.EndDate = new System.Windows.Forms.TextBox();
            this.CostSum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tariff = new System.Windows.Forms.TextBox();
            this.PrintContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintContainer
            // 
            this.PrintContainer.Controls.Add(this.PrintTicket);
            this.PrintContainer.Controls.Add(this.CarNum);
            this.PrintContainer.Controls.Add(this.CarNumLabel);
            this.PrintContainer.Location = new System.Drawing.Point(9, 10);
            this.PrintContainer.Margin = new System.Windows.Forms.Padding(2);
            this.PrintContainer.Name = "PrintContainer";
            this.PrintContainer.Size = new System.Drawing.Size(293, 204);
            this.PrintContainer.TabIndex = 1;
            this.PrintContainer.Visible = false;
            // 
            // PrintTicket
            // 
            this.PrintTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PrintTicket.Location = new System.Drawing.Point(14, 128);
            this.PrintTicket.Margin = new System.Windows.Forms.Padding(2);
            this.PrintTicket.Name = "PrintTicket";
            this.PrintTicket.Size = new System.Drawing.Size(257, 48);
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
            this.CarNum.Location = new System.Drawing.Point(14, 63);
            this.CarNum.Margin = new System.Windows.Forms.Padding(2);
            this.CarNum.Name = "CarNum";
            this.CarNum.Size = new System.Drawing.Size(258, 44);
            this.CarNum.TabIndex = 2;
            // 
            // CarNumLabel
            // 
            this.CarNumLabel.AutoSize = true;
            this.CarNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CarNumLabel.Location = new System.Drawing.Point(37, 18);
            this.CarNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CarNumLabel.Name = "CarNumLabel";
            this.CarNumLabel.Size = new System.Drawing.Size(199, 37);
            this.CarNumLabel.TabIndex = 0;
            this.CarNumLabel.Text = "მანქანის ნომერი";
            // 
            // validTimer
            // 
            this.validTimer.Tick += new System.EventHandler(this.validTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tariff);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CostSum);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Controls.Add(this.CarInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.myList);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.scanText);
            this.panel1.Location = new System.Drawing.Point(306, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 370);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "მანქანის ნომერი";
            // 
            // myList
            // 
            this.myList.FormattingEnabled = true;
            this.myList.Location = new System.Drawing.Point(9, 306);
            this.myList.Margin = new System.Windows.Forms.Padding(2);
            this.myList.Name = "myList";
            this.myList.Size = new System.Drawing.Size(386, 43);
            this.myList.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(9, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 85);
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
            this.scanText.Location = new System.Drawing.Point(124, 15);
            this.scanText.Margin = new System.Windows.Forms.Padding(2);
            this.scanText.Name = "scanText";
            this.scanText.Size = new System.Drawing.Size(258, 44);
            this.scanText.TabIndex = 5;
            this.scanText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "შემოვიდა";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "გავიდა";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "თანხა";
            // 
            // CarInput
            // 
            this.CarInput.Location = new System.Drawing.Point(191, 145);
            this.CarInput.Name = "CarInput";
            this.CarInput.Size = new System.Drawing.Size(100, 20);
            this.CarInput.TabIndex = 13;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(192, 178);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(100, 20);
            this.StartDate.TabIndex = 14;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(192, 211);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(100, 20);
            this.EndDate.TabIndex = 15;
            // 
            // CostSum
            // 
            this.CostSum.Location = new System.Drawing.Point(192, 244);
            this.CostSum.Name = "CostSum";
            this.CostSum.Size = new System.Drawing.Size(100, 20);
            this.CostSum.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "ტარიფი";
            // 
            // Tariff
            // 
            this.Tariff.Location = new System.Drawing.Point(192, 270);
            this.Tariff.Name = "Tariff";
            this.Tariff.Size = new System.Drawing.Size(100, 20);
            this.Tariff.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PrintContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CostSum;
        private System.Windows.Forms.TextBox EndDate;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.TextBox CarInput;
        private System.Windows.Forms.TextBox Tariff;
        private System.Windows.Forms.Label label5;
    }
}


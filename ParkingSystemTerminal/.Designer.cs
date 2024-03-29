﻿namespace ParkingSystemTerminal {
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
            this.SpentHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tariff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CostSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.scanText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.PrintContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintContainer
            // 
            this.PrintContainer.Controls.Add(this.PrintTicket);
            this.PrintContainer.Controls.Add(this.CarNum);
            this.PrintContainer.Controls.Add(this.CarNumLabel);
            this.PrintContainer.Location = new System.Drawing.Point(4, 0);
            this.PrintContainer.Margin = new System.Windows.Forms.Padding(2);
            this.PrintContainer.Name = "PrintContainer";
            this.PrintContainer.Size = new System.Drawing.Size(426, 323);
            this.PrintContainer.TabIndex = 1;
            this.PrintContainer.Visible = false;
            // 
            // PrintTicket
            // 
            this.PrintTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PrintTicket.Location = new System.Drawing.Point(79, 191);
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
            this.CarNum.Location = new System.Drawing.Point(79, 126);
            this.CarNum.Margin = new System.Windows.Forms.Padding(2);
            this.CarNum.Name = "CarNum";
            this.CarNum.Size = new System.Drawing.Size(258, 44);
            this.CarNum.TabIndex = 2;
            // 
            // CarNumLabel
            // 
            this.CarNumLabel.AutoSize = true;
            this.CarNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CarNumLabel.Location = new System.Drawing.Point(102, 81);
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
            this.panel1.Controls.Add(this.SpentHours);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tariff);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CostSum);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.scanText);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 323);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SpentHours
            // 
            this.SpentHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpentHours.Location = new System.Drawing.Point(301, 73);
            this.SpentHours.Name = "SpentHours";
            this.SpentHours.ReadOnly = true;
            this.SpentHours.Size = new System.Drawing.Size(102, 38);
            this.SpentHours.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "საათი";
            // 
            // Tariff
            // 
            this.Tariff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tariff.Location = new System.Drawing.Point(301, 150);
            this.Tariff.Name = "Tariff";
            this.Tariff.ReadOnly = true;
            this.Tariff.Size = new System.Drawing.Size(102, 38);
            this.Tariff.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "ტარიფი";
            // 
            // CostSum
            // 
            this.CostSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostSum.Location = new System.Drawing.Point(301, 227);
            this.CostSum.Name = "CostSum";
            this.CostSum.ReadOnly = true;
            this.CostSum.Size = new System.Drawing.Size(102, 38);
            this.CostSum.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(24, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 119);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "თანხა";
            // 
            // scanText
            // 
            this.scanText.AccessibleName = "";
            this.scanText.BackColor = System.Drawing.Color.White;
            this.scanText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.scanText.Location = new System.Drawing.Point(24, 72);
            this.scanText.Margin = new System.Windows.Forms.Padding(2);
            this.scanText.Name = "scanText";
            this.scanText.Size = new System.Drawing.Size(213, 44);
            this.scanText.TabIndex = 5;
            this.scanText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(303, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 48);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 48);
            this.button3.TabIndex = 22;
            this.button3.Text = "ტერმინალის შეცვლა";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.Location = new System.Drawing.Point(226, 330);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(73, 48);
            this.SettingsBtn.TabIndex = 23;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 384);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PrintContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Terminal";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostSum;
        private System.Windows.Forms.TextBox Tariff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpentHours;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SettingsBtn;
    }
}


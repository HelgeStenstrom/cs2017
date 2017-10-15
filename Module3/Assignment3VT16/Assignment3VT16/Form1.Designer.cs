namespace Assignment3VT16
{
    partial class Form1
    {
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
            this.groupBoxFuel = new System.Windows.Forms.GroupBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.currFuelBux = new System.Windows.Forms.TextBox();
            this.prevOdoBox = new System.Windows.Forms.TextBox();
            this.currOdoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.currFuelLabel = new System.Windows.Forms.Label();
            this.prevLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBMI = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxBmiResults = new System.Windows.Forms.GroupBox();
            this.groupBoxFuel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxBMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFuel
            // 
            this.groupBoxFuel.Controls.Add(this.priceBox);
            this.groupBoxFuel.Controls.Add(this.currFuelBux);
            this.groupBoxFuel.Controls.Add(this.prevOdoBox);
            this.groupBoxFuel.Controls.Add(this.currOdoBox);
            this.groupBoxFuel.Controls.Add(this.button1);
            this.groupBoxFuel.Controls.Add(this.priceLabel);
            this.groupBoxFuel.Controls.Add(this.currFuelLabel);
            this.groupBoxFuel.Controls.Add(this.prevLabel);
            this.groupBoxFuel.Controls.Add(this.currentLabel);
            this.groupBoxFuel.Controls.Add(this.groupBox2);
            this.groupBoxFuel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Size = new System.Drawing.Size(313, 348);
            this.groupBoxFuel.TabIndex = 0;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "Fuel";
            this.groupBoxFuel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(207, 100);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 9;
            // 
            // currFuelBux
            // 
            this.currFuelBux.Location = new System.Drawing.Point(207, 73);
            this.currFuelBux.Name = "currFuelBux";
            this.currFuelBux.Size = new System.Drawing.Size(100, 20);
            this.currFuelBux.TabIndex = 8;
            // 
            // prevOdoBox
            // 
            this.prevOdoBox.Location = new System.Drawing.Point(207, 46);
            this.prevOdoBox.Name = "prevOdoBox";
            this.prevOdoBox.Size = new System.Drawing.Size(100, 20);
            this.prevOdoBox.TabIndex = 7;
            // 
            // currOdoBox
            // 
            this.currOdoBox.Location = new System.Drawing.Point(207, 20);
            this.currOdoBox.Name = "currOdoBox";
            this.currOdoBox.Size = new System.Drawing.Size(100, 20);
            this.currOdoBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(7, 98);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price per liter";
            // 
            // currFuelLabel
            // 
            this.currFuelLabel.AutoSize = true;
            this.currFuelLabel.Location = new System.Drawing.Point(7, 72);
            this.currFuelLabel.Name = "currFuelLabel";
            this.currFuelLabel.Size = new System.Drawing.Size(177, 13);
            this.currFuelLabel.TabIndex = 3;
            this.currFuelLabel.Text = "Current amount of fuel tanked (liters)";
            this.currFuelLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // prevLabel
            // 
            this.prevLabel.AutoSize = true;
            this.prevLabel.Location = new System.Drawing.Point(7, 46);
            this.prevLabel.Name = "prevLabel";
            this.prevLabel.Size = new System.Drawing.Size(156, 13);
            this.prevLabel.TabIndex = 2;
            this.prevLabel.Text = "Previous odometer reading (km)";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(7, 20);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(149, 13);
            this.currentLabel.TabIndex = 1;
            this.currentLabel.Text = "Current odometer reading (km)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(257, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "kr/km";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(257, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Lit/\"mil\"";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(257, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "lit/mile";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(257, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "lit/km";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(257, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "km/lit";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cost per km";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fuel consumption (lit/\"mil\")";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fuel consumption (lit/US mile)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fuel consumption (lit/km)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fuel consumption (km/lit)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBoxBMI
            // 
            this.groupBoxBMI.Controls.Add(this.button2);
            this.groupBoxBMI.Controls.Add(this.textBox7);
            this.groupBoxBMI.Controls.Add(this.textBox6);
            this.groupBoxBMI.Controls.Add(this.textBox5);
            this.groupBoxBMI.Controls.Add(this.radioButton2);
            this.groupBoxBMI.Controls.Add(this.radioButton1);
            this.groupBoxBMI.Controls.Add(this.label12);
            this.groupBoxBMI.Controls.Add(this.label11);
            this.groupBoxBMI.Controls.Add(this.label10);
            this.groupBoxBMI.Controls.Add(this.groupBoxBmiResults);
            this.groupBoxBMI.Location = new System.Drawing.Point(347, 12);
            this.groupBoxBMI.Name = "groupBoxBMI";
            this.groupBoxBMI.Size = new System.Drawing.Size(342, 348);
            this.groupBoxBMI.TabIndex = 1;
            this.groupBoxBMI.TabStop = false;
            this.groupBoxBMI.Text = "BMI";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(76, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(76, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(76, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 20);
            this.textBox5.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(201, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "US Unit (lb, inch)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(201, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Metric Unit (kg, cm)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Weight (kg)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Height (cm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Your name";
            // 
            // groupBoxBmiResults
            // 
            this.groupBoxBmiResults.Location = new System.Drawing.Point(16, 239);
            this.groupBoxBmiResults.Name = "groupBoxBmiResults";
            this.groupBoxBmiResults.Size = new System.Drawing.Size(243, 100);
            this.groupBoxBmiResults.TabIndex = 0;
            this.groupBoxBmiResults.TabStop = false;
            this.groupBoxBmiResults.Text = "Results for NoName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 372);
            this.Controls.Add(this.groupBoxBMI);
            this.Controls.Add(this.groupBoxFuel);
            this.Name = "Form1";
            this.Text = "Universal Calculator";
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxBMI.ResumeLayout(false);
            this.groupBoxBMI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFuel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxBMI;
        private System.Windows.Forms.GroupBox groupBoxBmiResults;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox currFuelBux;
        private System.Windows.Forms.TextBox prevOdoBox;
        private System.Windows.Forms.TextBox currOdoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label currFuelLabel;
        private System.Windows.Forms.Label prevLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}


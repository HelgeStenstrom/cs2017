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
            this.calcFuelButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.currFuelLabel = new System.Windows.Forms.Label();
            this.prevLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fuelCostPerDist = new System.Windows.Forms.Label();
            this.fuelConsLitSwMil = new System.Windows.Forms.Label();
            this.fuelConsLitMile = new System.Windows.Forms.Label();
            this.fuelConsLitKm = new System.Windows.Forms.Label();
            this.fuelConsKmLit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBMI = new System.Windows.Forms.GroupBox();
            this.calcBmiButton = new System.Windows.Forms.Button();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.UsRadio = new System.Windows.Forms.RadioButton();
            this.metricRadio = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxBmiResults = new System.Windows.Forms.GroupBox();
            this.BmrBox = new System.Windows.Forms.GroupBox();
            this.BmrResultLabel = new System.Windows.Forms.Label();
            this.activityLevelBox = new System.Windows.Forms.GroupBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.CalcBmrButton = new System.Windows.Forms.Button();
            this.groupBoxFuel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxBMI.SuspendLayout();
            this.BmrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFuel
            // 
            this.groupBoxFuel.Controls.Add(this.priceBox);
            this.groupBoxFuel.Controls.Add(this.currFuelBux);
            this.groupBoxFuel.Controls.Add(this.prevOdoBox);
            this.groupBoxFuel.Controls.Add(this.currOdoBox);
            this.groupBoxFuel.Controls.Add(this.calcFuelButton);
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
            // calcFuelButton
            // 
            this.calcFuelButton.Location = new System.Drawing.Point(131, 135);
            this.calcFuelButton.Name = "calcFuelButton";
            this.calcFuelButton.Size = new System.Drawing.Size(75, 23);
            this.calcFuelButton.TabIndex = 5;
            this.calcFuelButton.Text = "Calculate";
            this.calcFuelButton.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.fuelCostPerDist);
            this.groupBox2.Controls.Add(this.fuelConsLitSwMil);
            this.groupBox2.Controls.Add(this.fuelConsLitMile);
            this.groupBox2.Controls.Add(this.fuelConsLitKm);
            this.groupBox2.Controls.Add(this.fuelConsKmLit);
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
            // fuelCostPerDist
            // 
            this.fuelCostPerDist.AutoSize = true;
            this.fuelCostPerDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelCostPerDist.Location = new System.Drawing.Point(257, 109);
            this.fuelCostPerDist.Name = "fuelCostPerDist";
            this.fuelCostPerDist.Size = new System.Drawing.Size(37, 15);
            this.fuelCostPerDist.TabIndex = 9;
            this.fuelCostPerDist.Text = "kr/km";
            this.fuelCostPerDist.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsLitSwMil
            // 
            this.fuelConsLitSwMil.AutoSize = true;
            this.fuelConsLitSwMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsLitSwMil.Location = new System.Drawing.Point(257, 87);
            this.fuelConsLitSwMil.Name = "fuelConsLitSwMil";
            this.fuelConsLitSwMil.Size = new System.Drawing.Size(47, 15);
            this.fuelConsLitSwMil.TabIndex = 8;
            this.fuelConsLitSwMil.Text = "Lit/\"mil\"";
            this.fuelConsLitSwMil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsLitMile
            // 
            this.fuelConsLitMile.AutoSize = true;
            this.fuelConsLitMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsLitMile.Location = new System.Drawing.Point(257, 66);
            this.fuelConsLitMile.Name = "fuelConsLitMile";
            this.fuelConsLitMile.Size = new System.Drawing.Size(39, 15);
            this.fuelConsLitMile.TabIndex = 7;
            this.fuelConsLitMile.Text = "lit/mile";
            this.fuelConsLitMile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsLitKm
            // 
            this.fuelConsLitKm.AutoSize = true;
            this.fuelConsLitKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsLitKm.Location = new System.Drawing.Point(257, 46);
            this.fuelConsLitKm.Name = "fuelConsLitKm";
            this.fuelConsLitKm.Size = new System.Drawing.Size(35, 15);
            this.fuelConsLitKm.TabIndex = 6;
            this.fuelConsLitKm.Text = "lit/km";
            this.fuelConsLitKm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsKmLit
            // 
            this.fuelConsKmLit.AutoSize = true;
            this.fuelConsKmLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsKmLit.Location = new System.Drawing.Point(257, 24);
            this.fuelConsKmLit.Name = "fuelConsKmLit";
            this.fuelConsKmLit.Size = new System.Drawing.Size(35, 15);
            this.fuelConsKmLit.TabIndex = 5;
            this.fuelConsKmLit.Text = "km/lit";
            this.fuelConsKmLit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.groupBoxBMI.Controls.Add(this.calcBmiButton);
            this.groupBoxBMI.Controls.Add(this.weightBox);
            this.groupBoxBMI.Controls.Add(this.heightBox);
            this.groupBoxBMI.Controls.Add(this.nameBox);
            this.groupBoxBMI.Controls.Add(this.UsRadio);
            this.groupBoxBMI.Controls.Add(this.metricRadio);
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
            // calcBmiButton
            // 
            this.calcBmiButton.Location = new System.Drawing.Point(100, 135);
            this.calcBmiButton.Name = "calcBmiButton";
            this.calcBmiButton.Size = new System.Drawing.Size(75, 23);
            this.calcBmiButton.TabIndex = 9;
            this.calcBmiButton.Text = "Calculate";
            this.calcBmiButton.UseVisualStyleBackColor = true;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(76, 72);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 8;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(76, 45);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(76, 18);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(230, 20);
            this.nameBox.TabIndex = 6;
            // 
            // UsRadio
            // 
            this.UsRadio.AutoSize = true;
            this.UsRadio.Location = new System.Drawing.Point(201, 73);
            this.UsRadio.Name = "UsRadio";
            this.UsRadio.Size = new System.Drawing.Size(105, 17);
            this.UsRadio.TabIndex = 5;
            this.UsRadio.TabStop = true;
            this.UsRadio.Text = "US Unit (lb, inch)";
            this.UsRadio.UseVisualStyleBackColor = true;
            // 
            // metricRadio
            // 
            this.metricRadio.AutoSize = true;
            this.metricRadio.Location = new System.Drawing.Point(201, 46);
            this.metricRadio.Name = "metricRadio";
            this.metricRadio.Size = new System.Drawing.Size(117, 17);
            this.metricRadio.TabIndex = 4;
            this.metricRadio.TabStop = true;
            this.metricRadio.Text = "Metric Unit (kg, cm)";
            this.metricRadio.UseVisualStyleBackColor = true;
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
            // BmrBox
            // 
            this.BmrBox.Controls.Add(this.CalcBmrButton);
            this.BmrBox.Controls.Add(this.BmrResultLabel);
            this.BmrBox.Controls.Add(this.activityLevelBox);
            this.BmrBox.Controls.Add(this.ageBox);
            this.BmrBox.Controls.Add(this.ageLabel);
            this.BmrBox.Controls.Add(this.maleButton);
            this.BmrBox.Controls.Add(this.femaleButton);
            this.BmrBox.Location = new System.Drawing.Point(12, 367);
            this.BmrBox.Name = "BmrBox";
            this.BmrBox.Size = new System.Drawing.Size(677, 282);
            this.BmrBox.TabIndex = 2;
            this.BmrBox.TabStop = false;
            this.BmrBox.Text = "BMR";
            // 
            // BmrResultLabel
            // 
            this.BmrResultLabel.BackColor = System.Drawing.SystemColors.Info;
            this.BmrResultLabel.Location = new System.Drawing.Point(263, 20);
            this.BmrResultLabel.Name = "BmrResultLabel";
            this.BmrResultLabel.Size = new System.Drawing.Size(378, 240);
            this.BmrResultLabel.TabIndex = 5;
            this.BmrResultLabel.Text = "BMR results go here";
            // 
            // activityLevelBox
            // 
            this.activityLevelBox.Location = new System.Drawing.Point(10, 104);
            this.activityLevelBox.Name = "activityLevelBox";
            this.activityLevelBox.Size = new System.Drawing.Size(200, 100);
            this.activityLevelBox.TabIndex = 4;
            this.activityLevelBox.TabStop = false;
            this.activityLevelBox.Text = "Activity level per week";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(68, 57);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(9, 57);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(92, 20);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(48, 17);
            this.maleButton.TabIndex = 1;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(10, 20);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(59, 17);
            this.femaleButton.TabIndex = 0;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // CalcBmrButton
            // 
            this.CalcBmrButton.Location = new System.Drawing.Point(68, 211);
            this.CalcBmrButton.Name = "CalcBmrButton";
            this.CalcBmrButton.Size = new System.Drawing.Size(75, 23);
            this.CalcBmrButton.TabIndex = 6;
            this.CalcBmrButton.Text = "button1";
            this.CalcBmrButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 661);
            this.Controls.Add(this.BmrBox);
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
            this.BmrBox.ResumeLayout(false);
            this.BmrBox.PerformLayout();
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
        private System.Windows.Forms.Button calcFuelButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label currFuelLabel;
        private System.Windows.Forms.Label prevLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton metricRadio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RadioButton UsRadio;
        private System.Windows.Forms.Label fuelCostPerDist;
        private System.Windows.Forms.Label fuelConsLitSwMil;
        private System.Windows.Forms.Label fuelConsLitMile;
        private System.Windows.Forms.Label fuelConsLitKm;
        private System.Windows.Forms.Label fuelConsKmLit;
        private System.Windows.Forms.Button calcBmiButton;
        private System.Windows.Forms.GroupBox BmrBox;
        private System.Windows.Forms.Label BmrResultLabel;
        private System.Windows.Forms.GroupBox activityLevelBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.Button CalcBmrButton;
    }
}


namespace Assignment3VT16
{
    partial class MainForm
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
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.boxFuelAmount = new System.Windows.Forms.TextBox();
            this.boxPrevOdo = new System.Windows.Forms.TextBox();
            this.boxCurrOdo = new System.Windows.Forms.TextBox();
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxBmiResults = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCategoryResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBmiResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BmrBox = new System.Windows.Forms.GroupBox();
            this.unselectButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.CalcBmrButton = new System.Windows.Forms.Button();
            this.BmrResultLabel = new System.Windows.Forms.Label();
            this.activityLevelBox = new System.Windows.Forms.GroupBox();
            this.radioActivity5 = new System.Windows.Forms.RadioButton();
            this.radioActivity4 = new System.Windows.Forms.RadioButton();
            this.radioActivity3 = new System.Windows.Forms.RadioButton();
            this.radioActivity2 = new System.Windows.Forms.RadioButton();
            this.radioActivity1 = new System.Windows.Forms.RadioButton();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.groupBoxFuel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxBMI.SuspendLayout();
            this.groupBoxBmiResults.SuspendLayout();
            this.BmrBox.SuspendLayout();
            this.activityLevelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFuel
            // 
            this.groupBoxFuel.Controls.Add(this.boxPrice);
            this.groupBoxFuel.Controls.Add(this.boxFuelAmount);
            this.groupBoxFuel.Controls.Add(this.boxPrevOdo);
            this.groupBoxFuel.Controls.Add(this.boxCurrOdo);
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
            // 
            // boxPrice
            // 
            this.boxPrice.Location = new System.Drawing.Point(207, 100);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(100, 20);
            this.boxPrice.TabIndex = 9;
            // 
            // boxFuelAmount
            // 
            this.boxFuelAmount.Location = new System.Drawing.Point(207, 73);
            this.boxFuelAmount.Name = "boxFuelAmount";
            this.boxFuelAmount.Size = new System.Drawing.Size(100, 20);
            this.boxFuelAmount.TabIndex = 8;
            // 
            // boxPrevOdo
            // 
            this.boxPrevOdo.Location = new System.Drawing.Point(207, 46);
            this.boxPrevOdo.Name = "boxPrevOdo";
            this.boxPrevOdo.Size = new System.Drawing.Size(100, 20);
            this.boxPrevOdo.TabIndex = 7;
            // 
            // boxCurrOdo
            // 
            this.boxCurrOdo.Location = new System.Drawing.Point(207, 20);
            this.boxCurrOdo.Name = "boxCurrOdo";
            this.boxCurrOdo.Size = new System.Drawing.Size(100, 20);
            this.boxCurrOdo.TabIndex = 6;
            // 
            // calcFuelButton
            // 
            this.calcFuelButton.Location = new System.Drawing.Point(207, 126);
            this.calcFuelButton.Name = "calcFuelButton";
            this.calcFuelButton.Size = new System.Drawing.Size(75, 23);
            this.calcFuelButton.TabIndex = 5;
            this.calcFuelButton.Text = "Calculate";
            this.calcFuelButton.UseVisualStyleBackColor = true;
            this.calcFuelButton.Click += new System.EventHandler(this.calcFuelButton_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(301, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // fuelCostPerDist
            // 
            this.fuelCostPerDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelCostPerDist.Location = new System.Drawing.Point(203, 109);
            this.fuelCostPerDist.Name = "fuelCostPerDist";
            this.fuelCostPerDist.Size = new System.Drawing.Size(70, 15);
            this.fuelCostPerDist.TabIndex = 9;
            this.fuelCostPerDist.Text = "kr/km";
            this.fuelCostPerDist.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsLitSwMil
            // 
            this.fuelConsLitSwMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsLitSwMil.Location = new System.Drawing.Point(203, 87);
            this.fuelConsLitSwMil.Name = "fuelConsLitSwMil";
            this.fuelConsLitSwMil.Size = new System.Drawing.Size(80, 15);
            this.fuelConsLitSwMil.TabIndex = 8;
            this.fuelConsLitSwMil.Text = "Lit/\"mil\"";
            this.fuelConsLitSwMil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsLitMile
            // 
            this.fuelConsLitMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsLitMile.Location = new System.Drawing.Point(203, 66);
            this.fuelConsLitMile.Name = "fuelConsLitMile";
            this.fuelConsLitMile.Size = new System.Drawing.Size(72, 15);
            this.fuelConsLitMile.TabIndex = 7;
            this.fuelConsLitMile.Text = "lit/mile";
            this.fuelConsLitMile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsLitKm
            // 
            this.fuelConsLitKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsLitKm.Location = new System.Drawing.Point(203, 46);
            this.fuelConsLitKm.Name = "fuelConsLitKm";
            this.fuelConsLitKm.Size = new System.Drawing.Size(68, 15);
            this.fuelConsLitKm.TabIndex = 6;
            this.fuelConsLitKm.Text = "lit/km";
            this.fuelConsLitKm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fuelConsKmLit
            // 
            this.fuelConsKmLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelConsKmLit.Location = new System.Drawing.Point(203, 24);
            this.fuelConsKmLit.Name = "fuelConsKmLit";
            this.fuelConsKmLit.Size = new System.Drawing.Size(68, 15);
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
            this.groupBoxBMI.Controls.Add(this.lblWeight);
            this.groupBoxBMI.Controls.Add(this.lblHeight);
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
            this.calcBmiButton.Location = new System.Drawing.Point(76, 126);
            this.calcBmiButton.Name = "calcBmiButton";
            this.calcBmiButton.Size = new System.Drawing.Size(75, 23);
            this.calcBmiButton.TabIndex = 9;
            this.calcBmiButton.Text = "Calculate";
            this.calcBmiButton.UseVisualStyleBackColor = true;
            this.calcBmiButton.Click += new System.EventHandler(this.calcBmiButton_Click);
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
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
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
            this.UsRadio.CheckedChanged += new System.EventHandler(this.UsRadio_CheckedChanged);
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
            this.metricRadio.CheckedChanged += new System.EventHandler(this.metricRadio_CheckedChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(13, 75);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 48);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(61, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (cm)";
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
            this.groupBoxBmiResults.Controls.Add(this.label13);
            this.groupBoxBmiResults.Controls.Add(this.lblCategoryResult);
            this.groupBoxBmiResults.Controls.Add(this.label3);
            this.groupBoxBmiResults.Controls.Add(this.lblBmiResult);
            this.groupBoxBmiResults.Controls.Add(this.label1);
            this.groupBoxBmiResults.Location = new System.Drawing.Point(6, 155);
            this.groupBoxBmiResults.Name = "groupBoxBmiResults";
            this.groupBoxBmiResults.Size = new System.Drawing.Size(300, 100);
            this.groupBoxBmiResults.TabIndex = 0;
            this.groupBoxBmiResults.TabStop = false;
            this.groupBoxBmiResults.Text = "Results for NoName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Normal BMI is between 18.5 and 24.9.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCategoryResult
            // 
            this.lblCategoryResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoryResult.Location = new System.Drawing.Point(180, 48);
            this.lblCategoryResult.Name = "lblCategoryResult";
            this.lblCategoryResult.Size = new System.Drawing.Size(100, 23);
            this.lblCategoryResult.TabIndex = 3;
            this.lblCategoryResult.Text = "label4";
            this.lblCategoryResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight Category";
            // 
            // lblBmiResult
            // 
            this.lblBmiResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmiResult.Location = new System.Drawing.Point(180, 20);
            this.lblBmiResult.Name = "lblBmiResult";
            this.lblBmiResult.Size = new System.Drawing.Size(100, 23);
            this.lblBmiResult.TabIndex = 1;
            this.lblBmiResult.Text = "label2";
            this.lblBmiResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your BMI";
            // 
            // BmrBox
            // 
            this.BmrBox.Controls.Add(this.unselectButton);
            this.BmrBox.Controls.Add(this.label14);
            this.BmrBox.Controls.Add(this.CalcBmrButton);
            this.BmrBox.Controls.Add(this.BmrResultLabel);
            this.BmrBox.Controls.Add(this.activityLevelBox);
            this.BmrBox.Controls.Add(this.ageBox);
            this.BmrBox.Controls.Add(this.ageLabel);
            this.BmrBox.Controls.Add(this.maleButton);
            this.BmrBox.Controls.Add(this.femaleButton);
            this.BmrBox.Location = new System.Drawing.Point(12, 367);
            this.BmrBox.Name = "BmrBox";
            this.BmrBox.Size = new System.Drawing.Size(677, 304);
            this.BmrBox.TabIndex = 2;
            this.BmrBox.TabStop = false;
            this.BmrBox.Text = "BMR";
            // 
            // unselectButton
            // 
            this.unselectButton.Location = new System.Drawing.Point(566, 276);
            this.unselectButton.Name = "unselectButton";
            this.unselectButton.Size = new System.Drawing.Size(75, 23);
            this.unselectButton.TabIndex = 8;
            this.unselectButton.Text = "Unselect";
            this.unselectButton.UseVisualStyleBackColor = true;
            this.unselectButton.Click += new System.EventHandler(this.unselectButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "-1";
            // 
            // CalcBmrButton
            // 
            this.CalcBmrButton.Location = new System.Drawing.Point(131, 253);
            this.CalcBmrButton.Name = "CalcBmrButton";
            this.CalcBmrButton.Size = new System.Drawing.Size(75, 23);
            this.CalcBmrButton.TabIndex = 6;
            this.CalcBmrButton.Text = "Calculate";
            this.CalcBmrButton.UseVisualStyleBackColor = true;
            this.CalcBmrButton.Click += new System.EventHandler(this.CalcBmrButton_Click);
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
            this.activityLevelBox.Controls.Add(this.radioActivity5);
            this.activityLevelBox.Controls.Add(this.radioActivity4);
            this.activityLevelBox.Controls.Add(this.radioActivity3);
            this.activityLevelBox.Controls.Add(this.radioActivity2);
            this.activityLevelBox.Controls.Add(this.radioActivity1);
            this.activityLevelBox.Location = new System.Drawing.Point(12, 93);
            this.activityLevelBox.Name = "activityLevelBox";
            this.activityLevelBox.Size = new System.Drawing.Size(200, 143);
            this.activityLevelBox.TabIndex = 4;
            this.activityLevelBox.TabStop = false;
            this.activityLevelBox.Text = "Activity level per week";
            // 
            // radioActivity5
            // 
            this.radioActivity5.AutoSize = true;
            this.radioActivity5.Location = new System.Drawing.Point(7, 115);
            this.radioActivity5.Name = "radioActivity5";
            this.radioActivity5.Size = new System.Drawing.Size(184, 17);
            this.radioActivity5.TabIndex = 4;
            this.radioActivity5.TabStop = true;
            this.radioActivity5.Text = "Extra active, hard exercises or job";
            this.radioActivity5.UseVisualStyleBackColor = true;
            // 
            // radioActivity4
            // 
            this.radioActivity4.AutoSize = true;
            this.radioActivity4.Location = new System.Drawing.Point(7, 91);
            this.radioActivity4.Name = "radioActivity4";
            this.radioActivity4.Size = new System.Drawing.Size(141, 17);
            this.radioActivity4.TabIndex = 3;
            this.radioActivity4.TabStop = true;
            this.radioActivity4.Text = "Very active (6 to 7 times)";
            this.radioActivity4.UseVisualStyleBackColor = true;
            // 
            // radioActivity3
            // 
            this.radioActivity3.AutoSize = true;
            this.radioActivity3.Location = new System.Drawing.Point(7, 67);
            this.radioActivity3.Name = "radioActivity3";
            this.radioActivity3.Size = new System.Drawing.Size(172, 17);
            this.radioActivity3.TabIndex = 2;
            this.radioActivity3.TabStop = true;
            this.radioActivity3.Text = "Moderately active (4 to 5 times)";
            this.radioActivity3.UseVisualStyleBackColor = true;
            // 
            // radioActivity2
            // 
            this.radioActivity2.AutoSize = true;
            this.radioActivity2.Location = new System.Drawing.Point(7, 44);
            this.radioActivity2.Name = "radioActivity2";
            this.radioActivity2.Size = new System.Drawing.Size(150, 17);
            this.radioActivity2.TabIndex = 1;
            this.radioActivity2.TabStop = true;
            this.radioActivity2.Text = "Lightly active (1 to 3 times)";
            this.radioActivity2.UseVisualStyleBackColor = true;
            // 
            // radioActivity1
            // 
            this.radioActivity1.AutoSize = true;
            this.radioActivity1.Location = new System.Drawing.Point(7, 20);
            this.radioActivity1.Name = "radioActivity1";
            this.radioActivity1.Size = new System.Drawing.Size(169, 17);
            this.radioActivity1.TabIndex = 0;
            this.radioActivity1.TabStop = true;
            this.radioActivity1.Text = "Sedentary (little or no exercise)";
            this.radioActivity1.UseVisualStyleBackColor = true;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(68, 57);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(69, 20);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 670);
            this.Controls.Add(this.BmrBox);
            this.Controls.Add(this.groupBoxBMI);
            this.Controls.Add(this.groupBoxFuel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Universal Calculator";
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxBMI.ResumeLayout(false);
            this.groupBoxBMI.PerformLayout();
            this.groupBoxBmiResults.ResumeLayout(false);
            this.groupBoxBmiResults.PerformLayout();
            this.BmrBox.ResumeLayout(false);
            this.BmrBox.PerformLayout();
            this.activityLevelBox.ResumeLayout(false);
            this.activityLevelBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFuel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxBMI;
        private System.Windows.Forms.GroupBox groupBoxBmiResults;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.TextBox boxFuelAmount;
        private System.Windows.Forms.TextBox boxPrevOdo;
        private System.Windows.Forms.TextBox boxCurrOdo;
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
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCategoryResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBmiResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioActivity5;
        private System.Windows.Forms.RadioButton radioActivity4;
        private System.Windows.Forms.RadioButton radioActivity3;
        private System.Windows.Forms.RadioButton radioActivity2;
        private System.Windows.Forms.RadioButton radioActivity1;
        private System.Windows.Forms.Button unselectButton;
        private System.Windows.Forms.Label label14;
    }
}


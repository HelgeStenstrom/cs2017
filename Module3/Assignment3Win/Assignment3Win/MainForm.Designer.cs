namespace Assignment3Win
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
            this.labelYourName = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.GroupBox();
            this.radioButtonUs = new System.Windows.Forms.RadioButton();
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.labelCatOut = new System.Windows.Forms.Label();
            this.labelBmiOut = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelYourBMI = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.unitBox.SuspendLayout();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelYourName
            // 
            this.labelYourName.AutoSize = true;
            this.labelYourName.Location = new System.Drawing.Point(13, 13);
            this.labelYourName.Name = "labelYourName";
            this.labelYourName.Size = new System.Drawing.Size(60, 13);
            this.labelYourName.TabIndex = 0;
            this.labelYourName.Text = "Your Name";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(16, 64);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 13);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height (cm)";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(19, 107);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(62, 13);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight (kg)";
            // 
            // unitBox
            // 
            this.unitBox.Controls.Add(this.radioButtonUs);
            this.unitBox.Controls.Add(this.radioButtonMetric);
            this.unitBox.Location = new System.Drawing.Point(250, 64);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(142, 100);
            this.unitBox.TabIndex = 3;
            this.unitBox.TabStop = false;
            this.unitBox.Text = "Unit";
            // 
            // radioButtonUs
            // 
            this.radioButtonUs.AutoSize = true;
            this.radioButtonUs.Location = new System.Drawing.Point(7, 45);
            this.radioButtonUs.Name = "radioButtonUs";
            this.radioButtonUs.Size = new System.Drawing.Size(108, 17);
            this.radioButtonUs.TabIndex = 1;
            this.radioButtonUs.TabStop = true;
            this.radioButtonUs.Text = "US Unit (foot, lbs)";
            this.radioButtonUs.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Location = new System.Drawing.Point(7, 20);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(114, 17);
            this.radioButtonMetric.TabIndex = 0;
            this.radioButtonMetric.TabStop = true;
            this.radioButtonMetric.Text = "Metric Unit (kg cm)";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(124, 56);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 5;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(124, 107);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 6;
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.labelCatOut);
            this.resultsBox.Controls.Add(this.labelBmiOut);
            this.resultsBox.Controls.Add(this.labelCategory);
            this.resultsBox.Controls.Add(this.labelYourBMI);
            this.resultsBox.Location = new System.Drawing.Point(19, 176);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(200, 100);
            this.resultsBox.TabIndex = 7;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results for";
            // 
            // labelCatOut
            // 
            this.labelCatOut.AutoSize = true;
            this.labelCatOut.Location = new System.Drawing.Point(145, 81);
            this.labelCatOut.Name = "labelCatOut";
            this.labelCatOut.Size = new System.Drawing.Size(35, 13);
            this.labelCatOut.TabIndex = 3;
            this.labelCatOut.Text = "label7";
            // 
            // labelBmiOut
            // 
            this.labelBmiOut.AutoSize = true;
            this.labelBmiOut.Location = new System.Drawing.Point(145, 36);
            this.labelBmiOut.Name = "labelBmiOut";
            this.labelBmiOut.Size = new System.Drawing.Size(35, 13);
            this.labelBmiOut.TabIndex = 2;
            this.labelBmiOut.Text = "label6";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(10, 81);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(86, 13);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Weight Category";
            // 
            // labelYourBMI
            // 
            this.labelYourBMI.AutoSize = true;
            this.labelYourBMI.Location = new System.Drawing.Point(7, 36);
            this.labelYourBMI.Name = "labelYourBMI";
            this.labelYourBMI.Size = new System.Drawing.Size(51, 13);
            this.labelYourBMI.TabIndex = 0;
            this.labelYourBMI.Text = "Your BMI";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(124, 141);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.Calc_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 307);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelYourName);
            this.Name = "MainForm";
            this.Text = "Body Mass Index";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.unitBox.ResumeLayout(false);
            this.unitBox.PerformLayout();
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.GroupBox unitBox;
        private System.Windows.Forms.RadioButton radioButtonUs;
        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Label labelCatOut;
        private System.Windows.Forms.Label labelBmiOut;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelYourBMI;
        private System.Windows.Forms.Button buttonCalculate;
    }
}


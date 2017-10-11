using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment3Win
{
    public partial class MainForm : Form
    {
        // create an instance of the bmi calculator
        private BMICalculator bmiCalc = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGUI()
        {
            this.Text = "The Body Mass Calculator";  // "this." is probably not necessary

            // input controls
            
        
        }
    }
}

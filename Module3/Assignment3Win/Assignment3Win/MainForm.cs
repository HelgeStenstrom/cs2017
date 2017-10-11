using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace Assignment3Win
{
    public partial class MainForm : Form
    {
        // create an instance of the BMI calculator
        private BmiCalculator _bmiCalc = new BmiCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGui()
        {
            Text = @"The Body Mass Calculator";

            // input controls
            SelectSystem(UnitSystem.Metric);
        }

        private void ReadHeight()
        {
            _bmiCalc.SetHeight(labelHeight.Text);
        }
        
        private void SelectSystem(UnitSystem system)
        {
            _bmiCalc.SetSystem(system);
            switch (system)
            {
                case UnitSystem.Metric:
                    radioButtonMetric.Checked = true;
                    radioButtonUs.Checked = false;
                    labelHeight.Text = "Your hight (cm)";
                    labelWeight.Text = "Your weight (kg)";
                    break;
                case UnitSystem.UsImperial:
                    radioButtonMetric.Checked = false;
                    radioButtonUs.Checked = true;
                    labelHeight.Text = "Your hight (feet)";
                    labelWeight.Text = "Your weight (lbs)";
                    break;
            }
        }
    }
}

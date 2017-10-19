using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3VT16
{
    public partial class MainForm : Form
    {
        // Create the calculators, with names suggested by VisualStudio
        CalorieCalculator CalorieCalcuator = new CalorieCalculator();
        BodyMassIndex BmiCalculator = new BodyMassIndex();
        FuelCalculator FuelCalculator = new FuelCalculator();

        private string name = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Fuel
            fuelConsKmLit.Text = String.Empty;
            fuelConsLitKm.Text = String.Empty;
            fuelConsLitMile.Text = String.Empty;
            fuelConsLitSwMil.Text = String.Empty;
            fuelCostPerDist.Text = String.Empty;

            // BMI
            metricRadio.Checked = true;
            // BMI results
            BmiResultLabel.Text = String.Empty;
            categoryResultLabel.Text = String.Empty;

            // BMR
            femaleButton.Checked = true;
            radioActivity2.Checked = true;
            BmrResultLabel.Text = String.Empty;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

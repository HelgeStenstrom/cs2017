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
        CalorieCalculator _calorieCalcuator = new CalorieCalculator();
        BodyMassIndex _bmiCalculator = new BodyMassIndex();
        FuelCalculator _fuelCalculator = new FuelCalculator();

        private string _name = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
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

        private void calcFuelButton_Click(object sender, EventArgs e)
        {
            
        }

        private void calcBmiButton_Click(object sender, EventArgs e)
        {

        }

        private void CalcBmrButton_Click(object sender, EventArgs e)
        {

        }

        private void unselectButton_Click(object sender, EventArgs e)
        {

        }
    }
}

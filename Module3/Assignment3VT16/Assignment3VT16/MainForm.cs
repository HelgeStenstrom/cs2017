using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
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
            // My code from here
            InitializeGui();
        }

        private void InitializeGui()
        {
            this.Text = "Universal Calculator";

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


        #region Fuel
        private void calcFuelButton_Click(object sender, EventArgs e)
        {
            String tCurrOdo = boxCurrOdo.Text;
            String tPrevOdo = boxPrevOdo.Text;
            String tFuelAmount = boxFuelAmount.Text;
            String tPrice = boxPrice.Text;

            double currentOdo;
            double previousOdo;
            double fuelAmount;
            double unitPrice;

            if (double.TryParse(tCurrOdo, out currentOdo))
            {
                _fuelCalculator.SetCurrentReading(currentOdo);
            }
            else
            {
                valueWarningBox("Current odometer reading");
            }

            if (double.TryParse(tPrevOdo, out previousOdo))
            {
                _fuelCalculator.SetPreviousReading(previousOdo);
            }
            else
            {
                valueWarningBox("Previous odometer reading");
            }

            if (double.TryParse(tFuelAmount, out fuelAmount))
            {
                _fuelCalculator.SetFuelAmount(fuelAmount);
            }
            else
            {
                valueWarningBox("Current amount of fuel");
            }

            if (double.TryParse(tPrice, out unitPrice))
            {
                _fuelCalculator.SetUnitPrice(unitPrice);
            }
            else
            {
                valueWarningBox("Price per liter");
            }

            if (! _fuelCalculator.ValidateOdometerValues())
            {
                MessageBox.Show("Values given are unreasonable. Check that they are non-negative,"
                    + " and that current odo is greater than previous odo.", "Error!");
            }


        }

        void valueWarningBox(string thing)
            // Pop up a warning that the input isn't a valid value
        {
            string formatted = String.Format("{0} is not a valid numerical value.", thing);
            MessageBox.Show(formatted, "Error!");
        }

        double validDouble ()
        {
            return 3.14;
        }
        #endregion

        #region BMI

        private void calcBmiButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BMR
        private void CalcBmrButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void unselectButton_Click(object sender, EventArgs e)
        {

        }
    }
}

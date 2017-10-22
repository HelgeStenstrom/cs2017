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
            lblBmiResult.Text = String.Empty;
            lblCategoryResult.Text = String.Empty;

            // BMR
            femaleButton.Checked = true;
            radioActivity2.Checked = true;
            BmrResultLabel.Text = String.Empty;


        }


        #region Fuel
        private void calcFuelButton_Click(object sender, EventArgs e)
        {            
            if (ReadInputFuel())
            {
                UpdateGuiFuel();
            }
            else
            {
                MessageBox.Show("Values given are unreasonable. Check that they are non-negative,"
                    + " and that current odo is greater than previous odo.", "Error!");
            }
        }

        private void UpdateGuiFuel()
        {
            fuelConsKmLit.Text = $"{_fuelCalculator.CalcConsumptionKilometerPerLiter():f2}";
            fuelConsLitKm.Text = $"{_fuelCalculator.CalcFuelConsumptionPerKm():f2}";
            fuelConsLitMile.Text = $"{_fuelCalculator.CalcConsumptionPerUsMile():f2}";
            fuelConsLitSwMil.Text = $"{_fuelCalculator.CalcFuelConsumptionPerSweMil():f2}";
            fuelCostPerDist.Text = $"{_fuelCalculator.CalcCostPerKm():f2}";
        }

        bool ReadInputFuel()
        {
            if (double.TryParse(boxCurrOdo.Text, out double currentOdo))
            {
                _fuelCalculator.SetCurrentReading(currentOdo);
            }
            else
            {
                valueWarningBox("Current odometer reading");
            }

            if (double.TryParse(boxPrevOdo.Text, out double previousOdo))
            {
                _fuelCalculator.SetPreviousReading(previousOdo);
            }
            else
            {
                valueWarningBox("Previous odometer reading");
            }

            if (double.TryParse(boxFuelAmount.Text, out double fuelAmount))
            {
                _fuelCalculator.SetFuelAmount(fuelAmount);
            }
            else
            {
                valueWarningBox("Current amount of fuel");
            }

            if (double.TryParse(boxPrice.Text, out double unitPrice))
            {
                _fuelCalculator.SetUnitPrice(unitPrice);
            }
            else
            {
                valueWarningBox("Price per liter");
            }
            return _fuelCalculator.ValidateOdometerValues();
        }
        
        #endregion
        void valueWarningBox(string thing)
            // Pop up a warning that the input isn't a valid value
        {
            string formatted = $"{thing} is not a valid numerical value.";
            MessageBox.Show(formatted, "Error!");
        }



        #region BMI
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            string name = nameBox.Text.Trim();
            if (!(name == ""))
            {
                this._name = name;
            }
            else
            {
                this._name = "No Name";
            }
            groupBoxBmiResults.Text = $"Results for {this._name}";
        }

        private void metricRadio_CheckedChanged(object sender, EventArgs e)
        {
            _bmiCalculator.SetUseMetric(true);
            _bmiCalculator.UseMetric = true;
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";
        }

        private void UsRadio_CheckedChanged(object sender, EventArgs e)
        {
            _bmiCalculator.SetUseMetric(false);
            _bmiCalculator.UseMetric = false;
            lblHeight.Text = "Height (inch)";
            lblWeight.Text = "Weight (lb)";
        }

        private void calcBmiButton_Click(object sender, EventArgs e)
        {
            if (ReadInputBmi())
            {
                UpdateGuiBmi();
            }
        }
        
        bool ReadInputBmi () 
        {
            bool ok = true;
            if (double.TryParse(heightBox.Text, out double hval))
            {
                _bmiCalculator.Height = hval;
            }
            else
            {
                valueWarningBox("Height");
                ok = false;
            }

            if (double.TryParse(weightBox.Text, out double wval))
            {
                _bmiCalculator.Weight = wval;
            }
            else
            {
                valueWarningBox("Weight");
                ok = false;
            }

            return ok;
        }
        
        private void UpdateGuiBmi()
        {
            double bmi = _bmiCalculator.calcBmi();
            lblBmiResult.Text = $"{bmi:f2}";
            string cat = _bmiCalculator.category();
            lblCategoryResult.Text = $"{cat}";
        }

        #endregion

        #region BMR
        private void CalcBmrButton_Click(object sender, EventArgs e)
        {
            
        }

        bool ReadInputBmr()
        {

            return true;
        }

        #endregion

        private void unselectButton_Click(object sender, EventArgs e)
        {

        }
    }
}

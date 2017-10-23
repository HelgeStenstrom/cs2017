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
        FuelCalculator _fuelCalculator = new FuelCalculator();
        BodyMassIndex _bmiCalculator = new BodyMassIndex();
        CalorieCalculator _calorieCalcuator = new CalorieCalculator();

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
            lblFuelConsKmLit.Text = String.Empty;
            lblFuelConsLitKm.Text = String.Empty;
            lblFuelConsLitMile.Text = String.Empty;
            lblFuelConsLitSwMil.Text = String.Empty;
            lblFuelCostPerDist.Text = String.Empty;

            // BMI
            rbtnMetric.Checked = true;
            // BMI results
            lblBmiResult.Text = String.Empty;
            lblCategoryResult.Text = String.Empty;

            // BMR
            btnFemale.Checked = true;
            radioActivity2.Checked = true;
            lblBmrResult.Text = String.Empty;


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
            lblFuelConsKmLit.Text = $"{_fuelCalculator.CalcConsumptionKilometerPerLiter():f2}";
            lblFuelConsLitKm.Text = $"{_fuelCalculator.CalcFuelConsumptionPerKm():f2}";
            lblFuelConsLitMile.Text = $"{_fuelCalculator.CalcConsumptionPerUsMile():f2}";
            lblFuelConsLitSwMil.Text = $"{_fuelCalculator.CalcFuelConsumptionPerSweMil():f2}";
            lblFuelCostPerDist.Text = $"{_fuelCalculator.CalcCostPerKm():f2}";
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
            if (double.TryParse(boxHeight.Text, out double hval))
            {
                _bmiCalculator.Height = hval;
            }
            else
            {
                valueWarningBox("Height");
                ok = false;
            }

            if (double.TryParse(boxWeight.Text, out double wval))
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
            
            if (ReadInputBmr())
            {
                // Happy path
                UpdateGuiBmr();
            }
        }

        private void UpdateGuiBmr()
        {
            lblBmrResult.Text = _calorieCalcuator.Report(this._name);
        }

        private void SetUnitSystem()
        {
            if (rbtnMetric.Checked)
                _calorieCalcuator.UseMetric = true;
            else
                _calorieCalcuator.UseMetric = false;
        }

        bool ReadInputBmr()
        {
            SetUnitSystem();
            bool ok = true;
            if (double.TryParse(boxHeight.Text, out double hval))
            {
                _calorieCalcuator.Height = hval;
            }
            else
            {
                valueWarningBox("Height");
                ok = false;
            }

            if (double.TryParse(boxWeight.Text, out double wval))
            {
                _calorieCalcuator.Weight = wval;
            }
            else
            {
                valueWarningBox("Weight");
                ok = false;
            }


            if (btnFemale.Checked)
                _calorieCalcuator.IsFemale = true;
            else
                _calorieCalcuator.IsFemale = false;

            SetActivityLevel();

            if (int.TryParse(ageBox.Text, out int age))
            {
                _calorieCalcuator.Age = age;
                if (ok)
                    return true;
            }
            else
            {
                valueWarningBox("Age");
                ok = false;
            }
            return false;
        }

        private void SetActivityLevel()
        {
            if (radioActivity1.Checked)
                _calorieCalcuator.ActivityLevel = 0;
            else if (radioActivity2.Checked)
                _calorieCalcuator.ActivityLevel = 1;
            else if (radioActivity3.Checked)
                _calorieCalcuator.ActivityLevel = 2;
            else if (radioActivity4.Checked)
                _calorieCalcuator.ActivityLevel = 3;
            else if (radioActivity5.Checked)
                _calorieCalcuator.ActivityLevel = 4;
        }

        #endregion

        private void unselectButton_Click(object sender, EventArgs e)
        {

        }
    }
}

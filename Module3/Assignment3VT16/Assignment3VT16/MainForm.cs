// Helge Stenström 2017-10-23


using System;
using System.Windows.Forms;

namespace Assignment3VT16
{
    public partial class MainForm : Form
    {
        // Create the calculators, with names suggested by VisualStudio
        private FuelCalculator _fuelCalculator = new FuelCalculator();
        private BodyMassIndex _bmiCalculator = new BodyMassIndex();
        private CalorieCalculator _calorieCalcuator = new CalorieCalculator();

        private string _name = String.Empty;

        public MainForm()
        // This is the standard way to start a windows form application.
        {
            InitializeComponent();
            // My code from here
            InitializeGui();
        }

        private void InitializeGui()
        // Set up reasonable, mainly empty, values for labels and text boxes.
        {
            Text = "Universal Calculator";

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
        // Methods having to do with fuel consumption.
        
        private void calcFuelButton_Click(object sender, EventArgs e)
        // This method is called when the Calculate button in the fuel section is clicked.
        {            
            if (ReadInputFuel())
            {
                // Happy path
                UpdateGuiFuel();
            }
            else
            {
                MessageBox.Show("Values given are unreasonable. Check that they are non-negative,"
                    + " and that current odo is greater than previous odo.", "Error!");
            }
        }

        private void UpdateGuiFuel()
        // Call calculation functions in the calculator. It has already got the imput data.
        // Set the return values to the appropriate labels.
        {
            lblFuelConsKmLit.Text = $"{_fuelCalculator.CalcConsumptionKilometerPerLiter():f2}";
            lblFuelConsLitKm.Text = $"{_fuelCalculator.CalcFuelConsumptionPerKm():f2}";
            lblFuelConsLitMile.Text = $"{_fuelCalculator.CalcConsumptionPerUsMile():f2}";
            lblFuelConsLitSwMil.Text = $"{_fuelCalculator.CalcFuelConsumptionPerSweMil():f2}";
            lblFuelCostPerDist.Text = $"{_fuelCalculator.CalcCostPerKm():f2}";
        }

        bool ReadInputFuel()
        // Convert text strings in the fuel input fiels into numbers, and do validation.
        // We check that strings can be parsed as numbers in this function,
        // and leave validation of the numbers to the calculator (called).
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
            // Return validated numbers.
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
        // Called when the value in the name box is changed,
        // in other words, each time a character is typed 
        // into the box. The GroupBox label which contains the name will be updated simulatneously.
        {
            string name = nameBox.Text.Trim();
            _name =  validatedName(name);
            groupBoxBmiResults.Text = $"Results for {_name}";
        }

        private string validatedName(string name)
        {
            if (!(name == ""))
                return name;
            else
                return "No Name";
        }

        private void metricRadio_CheckedChanged(object sender, EventArgs e)
        // take care of the unit setting (metric case)
        {
            // The following two calls contains are redundant. 
            // But I'm trying out different ways to do it.
            _bmiCalculator.SetUseMetric(true);  // Setter method
            _bmiCalculator.UseMetric = true;    // attribute
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";
        }

        private void UsRadio_CheckedChanged(object sender, EventArgs e)
        // Like the above, but US case.
        {
            // Same redundancy as commented above.
            _bmiCalculator.SetUseMetric(false);
            _bmiCalculator.UseMetric = false;
            lblHeight.Text = "Height (inch)";
            lblWeight.Text = "Weight (lb)";
        }

        private void calcBmiButton_Click(object sender, EventArgs e)
        // Called when the Calculate button in the BMI area is clicked.
        {
            if (ReadInputBmi())  // First read, validate and store input values
            {
                UpdateGuiBmi();  // then use the values to do calculations and update the GUI
            }
        }
        
        bool ReadInputBmi () 
        // Read, validate and store input values
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
        // Calculate and present BMI values
        {
            double bmi = _bmiCalculator.CalcBmi();
            lblBmiResult.Text = $"{bmi:f2}";
            string cat = _bmiCalculator.Category();
            lblCategoryResult.Text = $"{cat}";
        }
        #endregion

        #region BMR
        private void CalcBmrButton_Click(object sender, EventArgs e)
        // Called when the Calculate button int BMR area is clicked.
        // Note that it uses inputs from the BMI area as well. 
        // Further depencencies between the two calculators have been avoided.
        {            
            if (ReadInputBmr())
            {
                // Happy path
                UpdateGuiBmr();
            }
        }

        private void UpdateGuiBmr()
        // The output for the BMR calculation is in a large text box.
        // "Label" is a bad design choice, since it's not possible to 
        // copy text from this text box to the clipboard.
        // But "Label" is requested in the assignment.
        {
            lblBmrResult.Text = _calorieCalcuator.Report(_name);
        }

        private void SetUnitSystem()
        // Use the radio buttons to set the UseMetric property of the calorieCalculator 
        {
            if (rbtnMetric.Checked)
                _calorieCalcuator.UseMetric = true;
            else
                _calorieCalcuator.UseMetric = false;
        }

        bool ReadInputBmr()
        // Read, validate and store the input values for BMR.
        {
            _name = validatedName(nameBox.Text);
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
            }
            return false;
        }

        private void SetActivityLevel()
        // Activity level radio buttons converted to a number 0-4.
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
        // Unused method for an unused button, that happened to be in the assignment screenshot.
        {
            // Do nothing.
        }
    }
}

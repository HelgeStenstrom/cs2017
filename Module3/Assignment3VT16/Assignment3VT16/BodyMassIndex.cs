// Helge Stenström 2017-10-23


namespace Assignment3VT16
{
    class BodyMassIndex
    // Calculations for body mass index.
    {
        // fields corresponding to the GUI fields in the BMI area.
        private double _height;
        private double _weight;
        private  bool _useMetric = true;

        // Property used to set the field
        public bool UseMetric
        {
            set => _useMetric = value;
        }
        public void SetUseMetric(bool usemetric)
        // The traditional setter method for _useMetric.
        {
            _useMetric = usemetric;
        }

        // Property used to set the field
        public double Height
        {
            set => _height = value; 
        }

        // Property used to set the field
        public double Weight
        {
            set => _weight = value;
        }

        public double CalcBmi()
        // Calculate the BMI, diffferent formulas for different unit systems.
        // It would be better to only do metric calculations, and to metric <--> US conversion 
        // at input and output.
        {
            if (_useMetric)
            {
                return _weight / ((_height / 100.0) * (_height / 100.0));
            }
            else
                return 703.0 * _weight / (_height * _height);
        }

        public string Category ()
        // Assess the body fat category.
        {
            double bmi = CalcBmi();
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal weight";
            else if (bmi < 30)
                return "Overweight";
            else if (bmi < 35)
                return "Obesity class I";
            else if (bmi < 40)
                return "Obesity class II";
            else 
                return "Obesity class III";
        }
    }
}

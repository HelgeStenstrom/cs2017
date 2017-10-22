using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3VT16
{
    class BodyMassIndex
    {
        // for name, use value in MainForm.cs
        double height;
        double weight;
        bool useMetric = true;

        public bool UseMetric
        {
            get => useMetric;
            set => useMetric = value;
        }

        public double Height
        {
            get => height;
            set => height = value; 
        }

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public double calcBmi()
        {
            if (useMetric)
            {
                return weight / ((height / 100.0) * (height / 100.0));
            }
            else
                return 703.0 * weight / (height * height);
        }

        public string category ()
        {
            double bmi = calcBmi();
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal weight";
            else if (bmi < 30)
                return "Overweight";
            else if (bmi < 35)
                return "Obesity class I";
            else if (bmi < 35)
                return "Obesity class II";
            else 
                return "Obesity class III";
        }

        public void SetUseMetric(bool useMetric)
        {
            this.useMetric = useMetric;
        }


    }
}

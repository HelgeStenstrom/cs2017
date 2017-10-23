using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3VT16
{
    // Class for the BMR part of the MainForm
    class CalorieCalculator
    {
        bool _isFemale;
        int _age;
        int _activityLevel;
        double _height;
        double _weight;
        bool _useMetric;


        public bool IsFemale { get => _isFemale; set => _isFemale = value; }
        public int Age { get => _age; set => _age = value; }
        public int ActivityLevel { get => _activityLevel; set => _activityLevel = value; }
        public double Height
        {
          
            set
            {
                if (UseMetric)
                    this._height = value;
                else this._height = value * 2.54;
            }
        }
        public double Weight
        {
            set
            {
                if (UseMetric)
                    this._weight = value;
                else
                    this._weight = value * 0.454;
            }
        }

        public bool UseMetric { get => _useMetric; set => _useMetric = value; }

        void Calculate()
        {

        }
        
        public string Report(string name)
        {
            string theText = BmrHeader(name);
            theText += "\n";
            theText += "\n";
            theText += BmrRepRow("Your BMR (calories/day)", Bmr());
            theText += BmrRepRow("Calories to maintain your weight", baseIntake());
            theText += BmrRepRow("Calories to lose 0,5 kb per week", baseIntake()-500);
            theText += BmrRepRow("Calories to lose 1 kg per week", baseIntake()-1000);
            theText += BmrRepRow("Calories to gain 0,5 kg per week", baseIntake()+500);
            theText += BmrRepRow("Calories to gain 1 kg per week", baseIntake()+1000);
            theText += "\nLoosing more than 1000 calories per day is to be avoided.";
            return theText;
        }

        string BmrHeader(string name)
        {
            return $"BMR results for {name}".ToUpper();
        }

        string BmrRepRow(string what, double value)
        {
            string s = $"{what,-40} {value,6:f1}\n";
            return s;
        }

        double BmrFactor(int level)
        {
            double[] factors = { 1.2, 1.375, 1.55, 1.725, 1.9 };
            return factors[level];
        }

        double BmrBase(double w, double h, int age)
        {
            return 10.0 * w + 6.25 * h - 5.0 * age;
        }

        double Bmr()
        {
            double adjust;
            if (_isFemale)
                adjust = -161.0;
            else
                adjust = 5.0;
            return adjust + BmrBase(_weight, _height, _age);
        }

        double baseIntake()
        {
            return Bmr() * BmrFactor(_activityLevel);
        }
    }
}

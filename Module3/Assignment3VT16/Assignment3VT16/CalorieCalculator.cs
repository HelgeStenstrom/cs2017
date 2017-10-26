// Helge Stenström 2017-10-23


namespace Assignment3VT16
{
    // Class for the BMR part of the MainForm
    public class CalorieCalculator
    {
        // The member variables / object attributes/whatever correspond 
        // to the relevant input fields in the GUI.
        private bool _isFemale;
        private int _age;
        private int _activityLevel;
        private double _height;
        private double _weight;
        private bool _useMetric;

        #region Properties  
        // Properties are syntactic sugar for setters and getters. We only use the setters.
        // Validation can be inserted here if we want.
        public bool IsFemale { get => _isFemale; set => _isFemale = value; }
        public int Age { get => _age; set => _age = value; }
        public int ActivityLevel { get => _activityLevel; set => _activityLevel = value; }

        // The Height and Weight properties are either metric or US unit values,
        // but the instance variables are metric values only. 
        public double Height
        {       
            set
            {
                if (UseMetric)
                    _height = value;
                else _height = value * 2.54;
            }
        }
        public double Weight
        {
            set
            {
                if (UseMetric)
                    _weight = value;
                else
                    _weight = value * 0.45359237;
            }
        }

        public bool UseMetric { get => _useMetric; set => _useMetric = value; }
        #endregion
        
        
        public string Report(string name)
        // Do calculations and format a report to be presented as the caller wishes.
        {
            string theText = $"BMR results for {name}".ToUpper();
            theText += "\n";
            theText += "\n";
            theText += BmrRepRow("Your BMR (calories/day)", Bmr());
            theText += BmrRepRow("Calories to maintain your weight", BaseIntake());
            theText += BmrRepRow("Calories to lose 0,5 kb per week", BaseIntake()-500);
            theText += BmrRepRow("Calories to lose 1 kg per week", BaseIntake()-1000);
            theText += BmrRepRow("Calories to gain 0,5 kg per week", BaseIntake()+500);
            theText += BmrRepRow("Calories to gain 1 kg per week", BaseIntake()+1000);
            theText += "\nLoosing more than 1000 calories per day is to be avoided.";
            return theText;
        }

        string BmrRepRow(string what, double value)
        // One of several similar rows in the report
        {
            string s = $"{what,-40} {value,6:f1}\n";
            return s;
        }

        double BmrFactor(int level)
        // The factor for BMR, that is dependent on the activity level.
        {
            // Should have error handling or validation, but we know 
            // that the level is in the range 0 to 4.
            double[] factors = { 1.2, 1.375, 1.55, 1.725, 1.9 };
            return factors[level];
        }

        double BmrBase(double w, double h, int age)
        // The base value for BMR, with no gender adjustment
        {
            return 10.0 * w + 6.25 * h - 5.0 * age;
        }

        double Bmr()
        // The base BMR adjusted for gender.
        {
            double adjust;
            if (_isFemale)
                adjust = -161.0;
            else
                adjust = 5.0;
            return adjust + BmrBase(_weight, _height, _age);
        }

        double BaseIntake()
        // The calorie intake needed to maintain weight.
        {
            return Bmr() * BmrFactor(_activityLevel);
        }
    }
}

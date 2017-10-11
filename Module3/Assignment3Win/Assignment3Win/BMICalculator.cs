//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace Assignment3Win
{
    class BmiCalculator
    {
        private double height;

        public double Height => height;

        private double weight;
        private UnitSystem system;

        private const double CmPerFoot = 12.0 * 2.54;
        private const double KgPerLbs = 0.45359237;

        public void SetHeight(string h)
        {
            double someHeight;
            if (double.TryParse(h, out someHeight))
                SetHeight(someHeight);
        }

        private void SetHeight(double h)
        {
            switch (system)
            {
                 case UnitSystem.Metric:
                     height = h;
                     break;
                 case UnitSystem.UsImperial:
                     height = FeetToCm(h);
                     break;
            }
        }

        public void SetSystem(UnitSystem s)
        {
            system = s;
        } 
        
        #region Unit conversions

        double CmToFeet(double cm)
        {
            return cm / CmPerFoot;
        }

        double FeetToCm(double feet)
        {
            return feet * CmPerFoot;
        }

        double LbsToKg(double lbs)
        {
            return lbs * KgPerLbs;
        }

        double KgToLbs(double kg)
        {
            return kg / KgPerLbs;
        }
        

        #endregion        
        
    }
}

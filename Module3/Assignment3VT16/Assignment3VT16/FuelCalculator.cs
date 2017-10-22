using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3VT16
{
    class FuelCalculator
    {
        double currentOdoReading;
        double previousOdoReading;
        double fuelAmount;
        double unitPrice;

        public FuelCalculator()
        {

        }
        public void Calculate()
        {
        }

        double distance()
        {
            return currentOdoReading - previousOdoReading;
        }

        public double CalcConsumptionKilometerPerLiter()
        // Consumption: km per liter: kmPerLit: (this value is used in other formulas):
        // How many kilometers the car be driven for a liter? 

        {
            return distance() / fuelAmount;
        }

        public double CalcConsumptionPerUsMile()
        {
            // There is no such thing as a metric mile. 
            // A mile is 1760 yards.
            // A yard is 3 feet
            // A foot is 12 inches
            // An inch is 2.54 cm (exactly)
            const double milePerKm = 1.609344; // Exact length of a mile in km
            return CalcFuelConsumptionPerKm() * milePerKm;
        }

        public double CalcCostPerKm()
        // Cost per km: Cost per km = litPerKm * unit price (price can be in any currency)
        {
            return CalcFuelConsumptionPerKm() * unitPrice;
        }

        public double CalcFuelConsumptionPerKm()
        // Consumption liter per km: litPerKm: How many liters the car burns for each km?
        {
            return fuelAmount / distance();
        }

        public double CalcFuelConsumptionPerSweMil()
        {
            return 10.0 * CalcFuelConsumptionPerKm();
        }

        #region Getters and Setters

        // These methods have names from the assignment, and use variables that sometimes have my own names.
        public double GetCurrentReading()
        {
            return currentOdoReading;
        }

        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        public double GetPreviousReading()
        {
            return previousOdoReading;
        }


        public void SetCurrentReading(double val)
        {
            currentOdoReading = val;
        }

        public void SetFuelAmount(double val)
        {
            fuelAmount = val;
        }

        public void SetPreviousReading(double val)
        {
            previousOdoReading = val;
        }

        public void SetUnitPrice(double val)
        {
            unitPrice = val;
        }

        #endregion

        public bool ValidateOdometerValues()
            // Check that instance variables for the odomenter have valid values
        {
            return (previousOdoReading >= 0) && (currentOdoReading >= previousOdoReading)
                && (fuelAmount > 0) && (unitPrice >= 0);
        }
    }
}

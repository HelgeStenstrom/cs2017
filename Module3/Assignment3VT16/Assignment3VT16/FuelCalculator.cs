namespace Assignment3VT16
{
    class FuelCalculator
    {
        // The member variables / object attributes/whatever correspond 
        // to the relevant input fields in the GUI.
        private double _currentOdoReading;
        private double _previousOdoReading;
        private double _fuelAmount;
        private double _unitPrice;

        
        double Distance()
        // Convenience function to calculate distance driven.
        {
            return _currentOdoReading - _previousOdoReading;
        }

        public double CalcConsumptionKilometerPerLiter()
        // Consumption: km per liter: kmPerLit: (this value is used in other formulas):
        // How many kilometers the car be driven for a liter? 

        {
            return Distance() / _fuelAmount;
        }

        public double CalcConsumptionPerUsMile()
        // Consumption per mile, calculated from consumption per km.
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
            return CalcFuelConsumptionPerKm() * _unitPrice;
        }

        public double CalcFuelConsumptionPerKm()
        // Consumption liter per km: litPerKm: How many liters the car burns for each km?
        {
            return _fuelAmount / Distance();
        }

        public double CalcFuelConsumptionPerSweMil()
        // A Swedish "mil" is 10 km, exactly.
        {
            return 10.0 * CalcFuelConsumptionPerKm();
        }

        #region Getters and Setters

        // These methods have names from the assignment, and use variables that sometimes have my own names.
        public double GetCurrentReading()
        {
            return _currentOdoReading;
        }

        public double GetFuelAmount()
        {
            return _fuelAmount;
        }

        public double GetPreviousReading()
        {
            return _previousOdoReading;
        }


        public void SetCurrentReading(double val)
        {
            _currentOdoReading = val;
        }

        public void SetFuelAmount(double val)
        {
            _fuelAmount = val;
        }

        public void SetPreviousReading(double val)
        {
            _previousOdoReading = val;
        }

        public void SetUnitPrice(double val)
        {
            _unitPrice = val;
        }

        #endregion

        public bool ValidateOdometerValues()
            // Check that instance variables for the odomenter have valid values
        {
            return (_previousOdoReading >= 0) && (_currentOdoReading >= _previousOdoReading)
                && (_fuelAmount > 0) && (_unitPrice >= 0);
        }
    }
}

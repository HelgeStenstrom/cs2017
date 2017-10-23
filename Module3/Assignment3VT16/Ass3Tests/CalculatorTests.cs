using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment3VT16;

namespace Ass3Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void reportContainsNameAndCalories()
        {
            CalorieCalculator calorieCalculator = new CalorieCalculator();
            calorieCalculator.UseMetric = true;
            calorieCalculator.Age = 37;
            calorieCalculator.Height = 165;
            calorieCalculator.Weight = 69;
            calorieCalculator.ActivityLevel = 1;
            calorieCalculator.IsFemale = true;


            // Assert.AreEqual("BMR RESULTS", calorieCalculator.Report("NONAME"));
            Assert.IsTrue(calorieCalculator.Report("Helge").StartsWith("BMR RESULTS FOR HELGE" ));
            Assert.IsTrue(calorieCalculator.Report("Nisse").Contains("NISSE"));
            Assert.IsTrue(calorieCalculator.Report("").Contains("1375.3"));
        }

        [TestMethod]
        public void FuelConsumptionCalculations()
        {
            // Setup
            FuelCalculator fuelCalculator = new FuelCalculator();
            fuelCalculator.SetCurrentReading(900);
            fuelCalculator.SetPreviousReading(100);
            fuelCalculator.SetFuelAmount(40);
            fuelCalculator.SetUnitPrice(12.84);

            // Exercise and validate
            Assert.AreEqual(20, fuelCalculator.CalcConsumptionKilometerPerLiter(), 0.01);
            Assert.AreEqual(0.05, fuelCalculator.CalcFuelConsumptionPerKm(), 0.01);
            Assert.AreEqual(0.08, fuelCalculator.CalcConsumptionPerUsMile(), 0.01);
            Assert.AreEqual(0.5, fuelCalculator.CalcFuelConsumptionPerSweMil(), 0.01);
            Assert.AreEqual(0.64, fuelCalculator.CalcCostPerKm(), 0.01);

            // Tear down by garbage collection.
        }

    }
}

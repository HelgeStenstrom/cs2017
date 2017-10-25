using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace Assignment4Test
{
    [TestClass]
    public class RecipeTestsNoSetup
    {
        [TestMethod]
        public void Recipe_CanBeCreated()
        {
            // Setup
            Recipe recipe = new Recipe(3);
            Assert.IsNotNull(recipe, "recipe should exist");
        }

        [TestMethod]
        public void CanAddOneIngredient()
        {
           // Assert.Fail();
        }
    }

    [TestClass]
    public class RecipeTests
    {
        Recipe r;
        const int numberOfSlots = 3;
        // [TestInitialize]
        public RecipeTests()
        { 
           r = new Recipe(numberOfSlots);
        }

        //[TestInitialize]
        public void setUp()
        {
            // Do nothing
        }

        [TestMethod]
        public void sizeOfIngredList()
        {
            Assert.AreEqual(numberOfSlots, r.Ingredients.Length);
        }

        [TestMethod]
        public void firstIngredientIsEmpty()
        {
            Assert.AreEqual(string.Empty, r.Ingredients[0]);
        }

        [TestMethod]
        public void findTheFirstVacantSlot()
        {
            r.Ingredients[0] = "nonempty";
            r.Ingredients[1] = "nonempty";
            int firstVacant = r.FindVacantPosition();
            Assert.AreEqual(2, firstVacant, 
                "Slots 0 and 1 are used, so 2 is vacant.");
        }

        [TestMethod]
        public void allSlotsAreOccupied()
        {
            // Setup
            for (int i = 0; i < r.Ingredients.Length; i++)
            {
                r.Ingredients[i] = "nonempty";
            }

            // Exercise
            int firstVacant = r.FindVacantPosition();
            
            // Verify
            Assert.AreEqual(-1, firstVacant, "-1 means not found");
        }

        [TestMethod]
        public void addAnIngredient()
        {
            // pre-condition
            Assert.AreEqual(0, r.FindVacantPosition(), "Initially all slots are empty");
            
            // exercise
            bool success = r.AddIngredient("milk");

            // verify
            Assert.AreEqual(1, r.FindVacantPosition(), "Now slot 0 is occupied");
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void cantAddIngredientWhenFull()
        {
            // Setup
            for (int i = 0; i < numberOfSlots; i++)
            {
                bool cando = r.AddIngredient("nonempty");
                // Precondition
                Assert.IsTrue(cando);
            }

            // Exercise
            // Add one extra, that doesn't fit
            bool success = r.AddIngredient("nonempty");

            // Verify
            Assert.IsFalse(success);

        }

        [TestMethod]
        public void setAndGetCategory()
        {
            r.Category = FoodCategory.Seafood;
            Assert.AreEqual(FoodCategory.Seafood, r.Category);
        }

        [TestMethod]
        public void setAndGetDescription()
        {
            string desc = "This is a recipe\nWith two line in it";
            r.Description = desc;
            Assert.AreEqual(desc, r.Description);
        }

        [TestMethod]
        public void ingredientListIsReplaceable()
        {
            string[] ingredList = { "apples", "bananas", "milk", "honey", "sugar" };

            // exercise setter
            r.Ingredients = ingredList;

            // Verify that the max number of ingredients is now different
            // namely 5.
            Assert.AreEqual(5, r.MaxNumOfIngredients);
        }

        [TestMethod]
        public void checkAnIndex()
        {
            // Precondition
            Assert.AreEqual(numberOfSlots, r.MaxNumOfIngredients);

            // Verify
            Assert.IsFalse(r.CheckIndex(-1), "negative index is not permitted");
            Assert.IsTrue(r.CheckIndex(0), "first slot");
            Assert.IsTrue(r.CheckIndex(numberOfSlots - 1), "last slot");
            Assert.IsFalse(r.CheckIndex(numberOfSlots), "first index after last slot");

            // r.Ingredients = ["one", "", "three", "four", ""];
        }

        [TestMethod]
        public void countTheIngredients()
        {
            // setup
            string[] ingreds = { "one", "", "three", "four", "" };
            r.Ingredients = ingreds;

            // verify
            Assert.AreEqual(3, r.CurrentNumOfIngredients());
        }

        [TestMethod]
        public void toString()
        {
            r.Name = "Bulle";
            r.AddIngredient("Adam");
            r.AddIngredient("Bertil");
            r.AddIngredient("Caesar");
            r.Description = "Ett gott bakverk som är vanligt i Sverige";
            r.Category = FoodCategory.Vegetarian;

            string expected = "Bulle                   3      Vegetarian     Ett gott bakver";
            string exp2 = $"{"Bulle",-20} {"3",4}      {"Vegetarian",-12}   {"Ett gott bakver",-15}";
            //Pre-condition for test
            Assert.AreEqual(expected, exp2);

            Assert.AreEqual(exp2, r.ToString());
        }

        [TestMethod]
        public void toStringWithNoDesc()
        {
            r.Name = "Bulle";
            r.AddIngredient("Adam");
            r.AddIngredient("Bertil");
            r.AddIngredient("Caesar");
            r.Description = "";
            r.Category = FoodCategory.Vegetarian;

            string expected = "Bulle                   3      Vegetarian     No description ";
            Assert.AreEqual(expected, r.ToString());
        }

        [TestMethod]
        public void swapIngredients()
        {
            // Setup
            r.AddIngredient("one");
            r.AddIngredient("two");
            r.AddIngredient("three");

            // Exercise
            // swap the "two"
            r.ChangeIngredientAt(1, "another");

            // Verify
            string[] expected = { "one", "another", "three" };
            // I know no way of comparing the whole array in one go.
            Assert.AreEqual(expected.Length, r.Ingredients.Length);
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], r.Ingredients[i]);
        }

    }


    [TestClass]
    public class RecipeManagerTests
    {
        [TestMethod]
        public void Manager_CanBeCreated()
        {
            // Setup
            RecipeManager recipeManager = new RecipeManager(17);
            Assert.IsNotNull(recipeManager, "It should exist");
            // throw new NotImplementedException();
        }
    }

    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void create_some_values()
        {
            FoodCategory fish = FoodCategory.Fish;
            FoodCategory meat = FoodCategory.Meat;
            FoodCategory veg = FoodCategory.Vegetarian;

            Assert.IsTrue(veg > meat, "Meat comes before Vegetarian");
            Assert.IsTrue(veg < fish, "Fish comes after vegetarian");
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

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
            Recipe recipe = new Recipe(17);
            Assert.IsNotNull(recipe, "recipe should exist");
        }

        [TestMethod]
        public void CanAddOneIntedient()
        {
           // Assert.Fail();
        }
    }

    [TestClass]
    public class RecipeTests
    {
        Recipe r;
        // [TestInitialize]
        public RecipeTests()
        { 
           r = new Recipe(5);
        }

        [TestMethod]
        public void sizeOfIngredList()
        {
            Assert.AreEqual(5, r.Ingredients.Length);
        }

        [TestMethod]
        public void firstIngredientIsEmpty()
        {
            Assert.AreEqual(string.Empty, r.Ingredients[0]);
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

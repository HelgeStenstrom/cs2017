using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace Assignment4Test
{
    [TestClass]
    public class RecipeTests
    {
        [TestMethod]
        public void Recipe_CanBeCreated()
        {
            // Setup
            Recipe recipe = new Recipe(17);
            Assert.IsNotNull(recipe, "recipe should exist");
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

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
            // throw new NotImplementedException();
        }
    }

    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void create_some_values()
        {
            FoodCategory c1 = FoodCategory.Fish;
            FoodCategory c2 = FoodCategory.Meat;
            FoodCategory c3 = FoodCategory.Vegetarian;

            Assert.IsTrue(c3 > c2, "Meat comes before Vegetarian");
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

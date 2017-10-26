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

        [TestMethod]
        public void failingIngredientSwap()
        {
            // Setup
            r.AddIngredient("one");
            Assert.IsFalse(r.ChangeIngredientAt(17, "x"), 
                "index is outside the allocated index range");
        }

        [TestMethod]
        public void getAndSetName()
        {
            r.Name = "Nisse";
            Assert.AreEqual("Nisse", r.Name);
        }

        [TestMethod]
        public void deleteAnIngredient()
        {
            // Setup
            r.AddIngredient("1");
            r.AddIngredient("2");
            r.AddIngredient("3");
            // pre-validation
            Assert.AreEqual("2", r.Ingredients[1]);
            // exercise
            // delete the "2"
            int idx = 1;
            bool result = r.DeleteIngredientAt(idx);

            // Verify
            Assert.IsTrue(result);
            Assert.AreEqual(string.Empty, r.Ingredients[idx]);
        }

        [TestMethod]
        public void failingDeleteAnIngredient()
        {
            // Setup
            r.AddIngredient("1");
            r.AddIngredient("2");
            r.AddIngredient("3");
            // pre-validation
            Assert.AreEqual("2", r.Ingredients[1]);
            // exercise
            // delete outside the range
            bool result = r.DeleteIngredientAt(numberOfSlots);

            // Verify
            Assert.IsFalse(result);
        }


    }


    [TestClass]
    public class RecipeManagerTests
    {
        RecipeManager rm;
        const int numberOfSlots = 3;

        [TestInitialize]
        public void setup()
        {
            rm = new RecipeManager(numberOfSlots);
        }

        [TestMethod]
        public void Manager_CanBeCreated()
        {
            Assert.IsNotNull(rm, "It should exist");
            // throw new NotImplementedException();
        }

        [TestMethod]
        public void createARecipManager()
        {
            // Implicit setup
            // Verify
            Assert.IsNotNull(rm);
        }

        [TestMethod]
        public void canAddItemsUpToFull()
        {
            // Three recipes will fitt, but not four.
            Recipe r = new Recipe(0);
            Assert.IsTrue(rm.Add(r));
            Assert.IsTrue(rm.Add(r));
            Assert.IsTrue(rm.Add(r));
            Assert.IsFalse(rm.Add(r));
        }

        [TestMethod]
        public void canAddWithAlternativeMethod()
        {
            rm.Add("name", FoodCategory.Fish, new string[] { "one", "two"});

            // Verify that it used a slot
            Assert.AreEqual(1, rm.GetCurrentNumOfItems());
        }

        [TestMethod]
        public void tooManyRecipecAltMethod()
        {
            // There is room for 3 recipes
            Assert.IsTrue( rm.Add("name", FoodCategory.Fish, new string[] {}));
            Assert.IsTrue(rm.Add("name", FoodCategory.Fish, new string[] { }));
            Assert.IsTrue(rm.Add("name", FoodCategory.Fish, new string[] { }));
            Assert.IsFalse(rm.Add("name", FoodCategory.Fish, new string[] { }));

        }

        [TestMethod]
        public void getTheLengt()
        {
            Assert.AreEqual(numberOfSlots, rm.NumOfItems);
        }

        [TestMethod]
        public void canDeleteAnElement()
        {
            // Setup
            Recipe r = new Recipe(1);
            rm.Add(r);
            rm.Add(r);
            // Pre-validation
            Assert.AreEqual(2, rm.GetCurrentNumOfItems());
            rm.DeleteElement(0);
            Assert.AreEqual(1, rm.GetCurrentNumOfItems());            
        }    
        
        [TestMethod]
        public void cantDeleteNegativeIndex()
        {
            Assert.IsFalse(rm.DeleteElement(-1));
        }

        [TestMethod]
        public void getIngredientsLucky()
        {
            // setup
            rm.Add("A", FoodCategory.Fish, new string[] {"a" });
            rm.Add("B", FoodCategory.Fish, new string[] { "Ba", "Bb" });

            // exercise
            string[] result = rm.GetIngredients(1);

            // Verify
            Assert.AreEqual("Ba", result[0]);
            Assert.AreEqual("Bb", result[1]);
        }

        [TestMethod]
        public void getIngredientsUnlucky()
        {
            Assert.AreEqual(0, rm.GetIngredients(-1).Length);
        }

        [TestMethod]
        public void gettingARecipe()
        {
            // Setup
            Recipe expected = new Recipe(0);
            rm.Add(expected);

            // Exercise
            Recipe actual = rm.GetRecipeAt(0);

            // Verify that we can get this particular recipe object
            Assert.AreSame(expected, actual, "The same recipe object");
        }

        [TestMethod]
        public void gettingRecipeUnlucky()
        {
            Assert.IsNull(rm.GetRecipeAt(-1));
        }

        [TestMethod]
        public void swappingElements()
        {
            // Setup
            Recipe r1 = new Recipe(0);
            Recipe r2 = new Recipe(0);
            rm.Add(r1);
            // Pre-condition
            Assert.AreNotSame(r1, r2);
            Assert.AreSame(r1, rm.GetRecipeAt(0));

            // Exercise
            bool success = rm.ChangeElement(0, r2);

            // Verify
            Assert.AreSame(r2, rm.GetRecipeAt(0));
            Assert.AreEqual(true, success);

        }

        [TestMethod]
        public void gettingRecipesAsText()
        {
            // Setup
            // Create two recipes without descriptions
            rm.Add("Name1", FoodCategory.Fish, new string[] { "x", "" });
            rm.Add("Name2", FoodCategory.Meat, new string[] { "x", "" });

            // Exercise
            string[] actual = rm.RecipeListToString();

            // Verify
            Assert.AreEqual(2, actual.Length);
            Assert.AreEqual("Name1                   1      Fish           No description ", actual[0]);
            Assert.AreEqual("Name2                   1      Meat           No description ", actual[1]);            

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
    public class FormIngredientsTests
    {

        [TestMethod]
        public void CreateAForm()
        {
            Recipe r = new Recipe(0);
            FormIngredients form = new FormIngredients(r);

            Assert.AreEqual("No Recipe Name", form.Text);
        }
    }
}

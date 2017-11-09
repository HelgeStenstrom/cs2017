using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace Assignment4Test
{


    [TestClass]
    public class RecipeTests
    {
        Recipe recipe;
        const int numberOfSlots = 3;

        [TestInitialize]
        public void setUp()
        { 
           recipe = new Recipe(numberOfSlots);
        }

        [TestMethod]
        public void Recipe_CanBeCreated()
        {
            // Verify
            Assert.IsNotNull(recipe, "recipe should exist");
        }

        [TestMethod]
        public void sizeOfIngredList()
        {
            Assert.AreEqual(numberOfSlots, recipe.Ingredients.Length);
        }

        [TestMethod]
        public void firstIngredientIsEmpty()
        {
            Assert.AreEqual(string.Empty, recipe.Ingredients[0]);
        }

        [TestMethod]
        public void findTheFirstVacantSlot()
        {
            recipe.Ingredients[0] = "nonempty";
            recipe.Ingredients[1] = "nonempty";
            int firstVacant = recipe.FindVacantPosition();
            Assert.AreEqual(2, firstVacant, 
                "Slots 0 and 1 are used, so 2 is vacant.");
        }

        [TestMethod]
        public void allSlotsAreOccupied()
        {
            // Setup
            for (int i = 0; i < recipe.Ingredients.Length; i++)
            {
                recipe.Ingredients[i] = "nonempty";
            }

            // Exercise
            int firstVacant = recipe.FindVacantPosition();
            
            // Verify
            Assert.AreEqual(-1, firstVacant, "-1 means not found");
        }

        [TestMethod]
        public void addAnIngredient()
        {
            // pre-condition
            Assert.AreEqual(0, recipe.FindVacantPosition(), "Initially all slots are empty");
            
            // exercise
            bool success = recipe.AddIngredient("milk");

            // verify
            Assert.AreEqual(1, recipe.FindVacantPosition(), "Now slot 0 is occupied");
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void cantAddIngredientWhenFull()
        {
            // Setup
            for (int i = 0; i < numberOfSlots; i++)
            {
                bool cando = recipe.AddIngredient("nonempty");
                // Precondition
                Assert.IsTrue(cando);
            }

            // Exercise
            // Add one extra, that doesn't fit
            bool success = recipe.AddIngredient("nonempty");

            // Verify
            Assert.IsFalse(success);

        }

        [TestMethod]
        public void setAndGetCategory()
        {
            recipe.Category = FoodCategory.Seafood;
            Assert.AreEqual(FoodCategory.Seafood, recipe.Category);
        }

        [TestMethod]
        public void setAndGetDescription()
        {
            string desc = "This is a recipe\nWith two line in it";
            recipe.Description = desc;
            Assert.AreEqual(desc, recipe.Description);
        }

        [TestMethod]
        public void ingredientListIsReplaceable()
        {
            string[] ingredList = { "apples", "bananas", "milk", "honey", "sugar" };

            // exercise setter
            recipe.Ingredients = ingredList;

            // Verify that the max number of ingredients is now different
            // namely 5.
            Assert.AreEqual(5, recipe.MaxNumOfIngredients);
        }

        [TestMethod]
        public void checkAnIndex()
        {
            // Precondition
            Assert.AreEqual(numberOfSlots, recipe.MaxNumOfIngredients);

            // Verify
            Assert.IsFalse(recipe.CheckIndex(-1), "negative index is not permitted");
            Assert.IsTrue(recipe.CheckIndex(0), "first slot");
            Assert.IsTrue(recipe.CheckIndex(numberOfSlots - 1), "last slot");
            Assert.IsFalse(recipe.CheckIndex(numberOfSlots), "first index after last slot");

            // r.Ingredients = ["one", "", "three", "four", ""];
        }

        [TestMethod]
        public void countTheIngredients()
        {
            // setup
            string[] ingreds = { "one", "", "three", "four", "" };
            recipe.Ingredients = ingreds;

            // verify
            Assert.AreEqual(3, recipe.CurrentNumOfIngredients());
        }

        [TestMethod]
        public void toString()
        {
            recipe.Name = "Bulle";
            recipe.AddIngredient("Adam");
            recipe.AddIngredient("Bertil");
            recipe.AddIngredient("Caesar");
            recipe.Description = "Ett gott bakverk som är vanligt i Sverige";
            recipe.Category = FoodCategory.Vegetarian;

            string expected = "Bulle                   3      Vegetarian     Ett gott bakver";
            string exp2 = $"{"Bulle",-20} {"3",4}      {"Vegetarian",-12}   {"Ett gott bakver",-15}";
            //Pre-condition for test
            Assert.AreEqual(expected, exp2);

            Assert.AreEqual(exp2, recipe.ToString());
        }

        [TestMethod]
        public void toStringWithNoDesc()
        {
            recipe.Name = "Bulle";
            recipe.AddIngredient("Adam");
            recipe.AddIngredient("Bertil");
            recipe.AddIngredient("Caesar");
            recipe.Description = "";
            recipe.Category = FoodCategory.Vegetarian;

            string expected = "Bulle                   3      Vegetarian     No description ";
            Assert.AreEqual(expected, recipe.ToString());
        }

        [TestMethod]
        public void swapIngredients()
        {
            // Setup
            recipe.AddIngredient("one");
            recipe.AddIngredient("two");
            recipe.AddIngredient("three");

            // Exercise
            // swap the "two"
            recipe.ChangeIngredientAt(1, "another");

            // Verify
            string[] expected = { "one", "another", "three" };
            // I know no way of comparing the whole array in one go.
            Assert.AreEqual(expected.Length, recipe.Ingredients.Length);
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], recipe.Ingredients[i]);
        }

        [TestMethod]
        public void failingIngredientSwap()
        {
            // Setup
            recipe.AddIngredient("one");
            Assert.IsFalse(recipe.ChangeIngredientAt(17, "x"), 
                "index is outside the allocated index range");
        }

        [TestMethod]
        public void getAndSetName()
        {
            recipe.Name = "Nisse";
            Assert.AreEqual("Nisse", recipe.Name);
        }

        [TestMethod]
        public void deleteAnIngredient()
        {
            // Setup
            recipe.AddIngredient("1");
            recipe.AddIngredient("2");
            recipe.AddIngredient("3");
            // pre-validation
            Assert.AreEqual("2", recipe.Ingredients[1]);
            // exercise
            // delete the "2"
            int idx = 1;
            bool result = recipe.DeleteIngredientAt(idx);

            // Verify
            Assert.IsTrue(result, "The delete should succeed.");
            Assert.AreEqual("3", recipe.Ingredients[1], "Position that follow the deleted one should be shifted.");
            Assert.AreEqual(string.Empty, recipe.Ingredients[2], "There should be an empty position after the delete.");
        }

        [TestMethod]
        public void failingDeleteAnIngredient()
        {
            // Setup
            recipe.AddIngredient("1");
            recipe.AddIngredient("2");
            recipe.AddIngredient("3");
            // pre-validation
            Assert.AreEqual("2", recipe.Ingredients[1]);
            // exercise
            // delete outside the range
            bool result = recipe.DeleteIngredientAt(numberOfSlots);

            // Verify
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void repacking()
        {
            // Setup
            recipe.Ingredients = new string[] { string.Empty, "b", "c" };
            Assert.AreEqual(string.Empty, "");

            // Exercise
            recipe.Repack();

            // Verify
            string[] expected = new string[] {"b", "c", string.Empty };
            for (int i = 0; i < 3; i++)
                Assert.AreEqual(expected[i], recipe.Ingredients[i], $" at position {i}.");
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
            Assert.IsTrue(rm.AddNew(r));
            Assert.IsTrue(rm.AddNew(r));
            Assert.IsTrue(rm.AddNew(r));
            Assert.IsFalse(rm.AddNew(r));
        }

        [TestMethod]
        public void canAddWithAlternativeMethod()
        {
            rm.AddNew("name", FoodCategory.Fish, new string[] { "one", "two"});

            // Verify that it used a slot
            Assert.AreEqual(1, rm.GetCurrentNumOfItems());
        }

        [TestMethod]
        public void tooManyRecipecAltMethod()
        {
            // There is room for 3 recipes
            Assert.IsTrue( rm.AddNew("name", FoodCategory.Fish, new string[] {}));
            Assert.IsTrue(rm.AddNew("name", FoodCategory.Fish, new string[] { }));
            Assert.IsTrue(rm.AddNew("name", FoodCategory.Fish, new string[] { }));
            Assert.IsFalse(rm.AddNew("name", FoodCategory.Fish, new string[] { }));

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
            rm.AddNew(r);
            rm.AddNew(r);
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
            rm.AddNew("A", FoodCategory.Fish, new string[] {"a" });
            rm.AddNew("B", FoodCategory.Fish, new string[] { "Ba", "Bb" });

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
            rm.AddOld(expected);

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
            rm.AddNew(r1);
            // Pre-condition
            Assert.AreNotSame(r1, r2);
            // Assert.AreSame(r1, rm.GetRecipeAt(0));

            // Exercise
            bool success = rm.ChangeElement(0, r2);

            // Verify
            Assert.AreSame(r2, rm.GetRecipeAt(0));
            Assert.IsTrue(success);

        }

        [TestMethod]
        public void gettingRecipesAsText()
        {
            // Setup
            // Create two recipes without descriptions
            rm.AddNew("Name1", FoodCategory.Fish, new string[] { "x", "" });
            rm.AddNew("Name2", FoodCategory.Meat, new string[] { "x", "" });

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
        public void CreateAForm_zeroIngredients()
        {
            Recipe r = new Recipe(0);
            FormIngredients form = new FormIngredients(r);
            // Verify
            Assert.AreEqual("No Recipe Name", form.Text);
        }

        [TestMethod]
        public void CreateAForm_namedRecipe()
        {
            // Setup
            Recipe r = new Recipe(0);
            r.Name = "aName";
            FormIngredients form = new FormIngredients(r);
            // Verify
            Assert.AreEqual("aName Add ingredients", form.Text);
        }

        [TestMethod]
        public void CreateAForm_twoIngredients()
        {
            Recipe r2 = new Recipe(2);
            FormIngredients form = new FormIngredients(r2);
            // Verify
            Assert.AreEqual("No Recipe Name", form.Text);
        }

        [Ignore]
        public void tooltip()
        {
            // Setup
            Recipe r = new Recipe(0);
            FormIngredients form = new FormIngredients(r);
            // The tooltip is not public. How can it be tested?
            Assert.IsNotNull(form.tooltip.ToString());
            Assert.AreEqual("Example: 2 dl milk", form.tooltip.ToolTipTitle);
            //Assert.Fail();
        }


    }

    [TestClass]
    public class MainFormTests
    {
        [TestInitialize]
        public void setup()
        {
            // nothing yet
        }

        [TestMethod]
        public void createInstance()
        {
            // Exercise
            FormMain mf = new FormMain();
        }

        [TestMethod]
        public void updatingTheGui()
        {
            // Setup
            FormMain mf = new FormMain();

            // Exercise
            // TODO: Hur kan jag testa UpdateGui?
            // metoden är privat.
            // Click-metoden som anropar den är också privat.
        }

    }
}

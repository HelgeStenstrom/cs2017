using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class RecipeManager
    {
        // Instance variables
        private Recipe[] recipeList;

        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }

        // Properties
        public int NumOfItems { get => recipeList.Length;  }

        // Public methods
        public bool AddOld(Recipe recipe)
        {
            int firstSlot = FindVacantPosition();
            if (firstSlot == -1)
                return false;
            else
            {
                recipeList[firstSlot] = recipe;
                return true;
            }
        }

        /// <summary>
        /// Add a recipe to the recipe list. The recipe will be new; 
        /// it's a copy of the recipe provided as argument to the method.
        /// </summary>
        /// <param name="recipe">Recipe to be copied into the recipe list.</param>
        /// <returns>True when successful</returns>
        public bool AddNew(Recipe recipe)
        {
            int firstSlot = FindVacantPosition();
            if (firstSlot == -1)
                return false;
            else
            {
                //recipeList[firstSlot] = recipe;

                return AddNew(recipe.Name, recipe.Category, recipe.Ingredients);
                // return true;
            }
        }

        public bool AddNew(string name, FoodCategory category, string[] ingredients)
        {
            int index = FindVacantPosition();
            if (index < 0)
                return false;
            else
            {
                Recipe recipe = new Recipe(ingredients.Length);
                recipe.Name = name;
                recipe.Ingredients = ingredients;
                recipe.Category = category;

                recipeList[index] = recipe;
                return true;
            }            
        }

        public string[] GetIngredients(int index)
        {
            if (!CheckIndex(index))
                return new string[] { };
            return recipeList[index].Ingredients;
        }
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
            // From "Clean Code" by Robert C Martin, page 110 (Chapter 7, Error handling)

            // Don’t Return Null

            // I think that any discussion about error handling should include mention of the 
            // things we do that invite errors.The first on the list is returning null.
            // I can’t begin to count the number of applications I’ve seen in which nearly 
            // every other line was a check for null.


            // From "Clean Code" by Robert C Martin, page 111 (Chapter 7, Error handling)

            // Don’t Pass Null
            // Returning null from methods is bad, but passing null into methods is worse.
            // Unless you are working with an API which expects you to pass null, you should
            //avoid passing null in your code whenever possible.

        }

        public bool ChangeElement(int index, Recipe recipe)
        {
            bool isValidIndex = CheckIndex(index);
            if (isValidIndex)
                recipeList[index] = recipe;
            return isValidIndex;
        }

        public bool DeleteRecipe(int index)
        {
            bool ok = CheckIndex(index);
            if (ok)
            {
                recipeList[index] = null;
                Repack();
            }                
            return ok;
        }

        public int GetCurrentNumOfRecipes()
        {
            int count = 0;
            for (int i=0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                    count += 1;
            }
            return count;
        }

        public string[] RecipeListToString()
        {
            string[] result = new string[GetCurrentNumOfRecipes()];
            for (int i = 0; i < result.Length; i++)
            {
                Recipe r = recipeList[i];
                if (IsValidRecipe(r))
                {
                    string s = r.ToString();
                    result[i] = s;
                }
            }
            return result;
        }

        /// <summary>
        /// Returnerar sant om receptet är "giltigt"
        /// </summary>
        /// <param name="r">En instans av klassen Recipe</param>
        /// <returns></returns>
        private bool IsValidRecipe(Recipe r)
        {
            return (!(r == null));
        }

        // Private methods

        private int FindVacantPosition()
        // Return the position of the first found vacant slot, or -1 if none found.
        {
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                    return i;
            }
            return -1;
        }

        private bool CheckIndex(int index)
            // Return True if the index is within the allocated range, False otherwise.
        {
            return (index >= 0 && index < recipeList.Length);
        }

        public void Repack()
        {

            Recipe[] updatedList = new Recipe[recipeList.Length];
            for (int i = 0; i < recipeList.Length; i++)
                updatedList[i] = null;

            int pos = 0;
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (!(recipeList[i] == null))
                {
                    updatedList[pos] = recipeList[i];
                    pos++;
                }
            }
            recipeList = updatedList;
        }
    }
}

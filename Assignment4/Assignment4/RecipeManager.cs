namespace Assignment4
{
    public class RecipeManager
    {
        // Instance variables
        private Recipe[] _recipeList;

        public RecipeManager(int maxNumOfElements)
        {
            _recipeList = new Recipe[maxNumOfElements];
        }

        // Properties
        public int NumOfItems { get => _recipeList.Length;  }

        // Public methods
        
        /// <summary>
        /// Add a recipe to the recipe list, whithout creating a new recipe. 
        /// The instance that the caller provides will be added to the list. 
        /// Use with caution.
        /// </summary>
        /// <param name="recipe">Recipe instance to be added</param>
        /// <returns>True if successful.</returns>
        public bool AddOld(Recipe recipe)
        {
            int firstSlot = FindVacantPosition();
            if (firstSlot == -1)
                return false;
            else
            {
                _recipeList[firstSlot] = recipe;
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

        /// <summary>
        /// Add a recipe to the recipe list. The recipe will be new; 
        /// created from the parameters given.
        /// </summary>
        /// <param name="name">The name of the recipe</param>
        /// <param name="category">The category of the recipe.</param>
        /// <param name="ingredients">A list of ingredients.</param>
        /// <returns>True if successful.</returns>
        public bool AddNew(string name, FoodCategory category, string[] ingredients)
        {
            int index = FindVacantPosition();
            if (index < 0)
                return false;
            Recipe recipe = new Recipe(ingredients.Length)
            {
                Name = name,
                Ingredients = ingredients,
                Category = category
            };

            _recipeList[index] = recipe;
            return true;
        }

        /// <summary>
        /// Return the ingredients of the recipe indexed.
        /// </summary>
        /// <param name="index">selects a recipe.</param>
        /// <returns>An ingredient list</returns>
        public string[] GetIngredients(int index)
        {
            if (!CheckIndex(index))
                return new string[] { };
            return _recipeList[index].Ingredients;
        }
        
        /// <summary>
        /// Return one recipe from the recipe list.
        /// </summary>
        /// <param name="index">Index of wanted recipe</param>
        /// <returns>The wanted recipe</returns>
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return _recipeList[index];
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

        /// <summary>
        /// Replace a recipe in the recipe list, with the instance given by the caller.
        /// </summary>
        /// <param name="index">The (index of the) recipe to replace</param>
        /// <param name="recipe">The recipe to put in the list</param>
        /// <returns>True if the index is valid, which should be equivalent with a successful repleacement.</returns>
        public bool ChangeElement(int index, Recipe recipe)
        {
            bool isValidIndex = CheckIndex(index);
            if (isValidIndex)
                _recipeList[index] = recipe;
            return isValidIndex;
        }

        /// <summary>
        /// Delete one recipe from the recipe list. Repack the list, so that there are no holes in it.
        /// </summary>
        /// <param name="index">Indes of the recipe to delete</param>
        /// <returns>True if successful.</returns>
        public bool DeleteRecipe(int index)
        {
            bool ok = CheckIndex(index);
            if (ok)
            {
                _recipeList[index] = null;
                Repack();
            }                
            return ok;
        }
        
        /// <summary>
        /// Return the current number of recipes (not the max number)
        /// </summary>
        /// <returns>The number of recipes.</returns>
        public int GetCurrentNumOfRecipes()
        {
            int count = 0;
            foreach (Recipe recipe in _recipeList)
            {
                if (recipe != null)
                    count += 1;
            }
            return count;
        }

        /// <summary>
        /// Return a list of string representations of the recipe list. One string per recipe.
        /// </summary>
        /// <returns>The strings of the recipes.</returns>
        public string[] RecipeListToString()
        {
            string[] result = new string[GetCurrentNumOfRecipes()];
            for (int i = 0; i < result.Length; i++)
            {
                Recipe r = _recipeList[i];
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
            return (r != null);
        }

        // Private methods

        private int FindVacantPosition()
        // Return the position of the first found vacant slot, or -1 if none found.
        {
            for (int i = 0; i < _recipeList.Length; i++)
            {
                if (_recipeList[i] == null)
                    return i;
            }
            return -1;
        }

        private bool CheckIndex(int index)
            // Return True if the index is within the allocated range, False otherwise.
        {
            return (index >= 0 && index < _recipeList.Length);
        }

        /// <summary>
        /// Remove holes in the recipe list.
        /// </summary>
        private void Repack()
        {
            Recipe[] updatedList = new Recipe[_recipeList.Length];
            for (int i = 0; i < _recipeList.Length; i++)
                updatedList[i] = null;

            int pos = 0;
            foreach (Recipe recipe in _recipeList)
            {
                if (recipe == null) continue;
                updatedList[pos] = recipe;
                pos++;
            }
            _recipeList = updatedList;
        }
    }
}

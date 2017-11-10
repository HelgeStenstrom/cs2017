using System;


namespace Assignment4
{
    public class Recipe
    {
        // Instance variables
        // We don't have any normal instance variables, only properties. 

        public Recipe(int maxNumOfIngredients)
        {
            Ingredients = new string[maxNumOfIngredients];
            DefaultValues();
        }

        // Properties
        public FoodCategory Category { get; set; }
        public string Description { get; set; }
        public string[] Ingredients { get; set; }
        public string Name { get; set; }
        public int MaxNumOfIngredients => Ingredients.Length;

        // TODO: properties CurrentNumOfIngredients

        // Methods
        
        public bool AddIngredient(string value)
        // Add an ingredient to the ingredient list of the recipe
        {          
            int firstSlot = FindVacantPosition();
            if (firstSlot == -1)
                return false;
            else
            {
                Ingredients[firstSlot] = value;
                return true;
            }                
        }
        public bool ChangeIngredientAt(int index, string value)
        // Change one position in the ingredient list.
        {
            if (CheckIndex(index))
            {
                Ingredients[index] = value;
                // TODO: consider repacking the list.
                return true;
            }
            else
                return false;
        }

        public bool CheckIndex(int index)
        // Check if the index is a valid index of the allocated array.
        {
            return (index >= 0) && (index < Ingredients.Length);
        }

        private void DefaultValues()
        // Set reasonable start values for all parts of a recipe.
        // We don't want null values floating around.
        {
            for (int i= 0; i < Ingredients.Length; i++)
            {
                Ingredients[i] = string.Empty;
            }
            Name = string.Empty;
            Category = FoodCategory.Vegetarian;
            Description = string.Empty;
        }

        public int FindVacantPosition()
        // Find an unused slot in the indredient list.
        {
            int foundSlot = -1;
            for (int i = 0; i < Ingredients.Length; i++)
            {
                if (string.IsNullOrEmpty(Ingredients[i]))
                {
                    return i;
                }
            }
            return foundSlot;
        }

        public override string ToString()
        // Return a string representation of the recipe. It will be used by the RecipeManager.
        {
            int chars = Math.Min(Description.Length, 15);
            string descriptionText = Description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText =  "No description";

            string textOut = $"{Name, -20} {CurrentNumOfIngredients,4}      {Category.ToString(), -12}   {descriptionText, -15}";

            return textOut;
        }

        public int CurrentNumOfIngredients
        // The number of the ingredients in the ingredients list, i.e., the number of used slots.
        // Just for fun, implement this as a property.
        {
            get
            {
                int count = 0;
                for (int i = 0; i < MaxNumOfIngredients; i++)
                {
                    if (!string.IsNullOrEmpty(Ingredients[i]))
                        count += 1;
                }
                return count;
            }
        }

        public bool DeleteIngredientAt(int index)
        // Remove an ingredient. Repack the list, so that there are no holes in it.
        {
            bool result = CheckIndex(index);
            if (result)
                Ingredients[index] = string.Empty;
            Repack();
            return result;
        }

        public void Repack()
        // Remove holes in the recipe list.
        {
            string[] updatedList = new string[MaxNumOfIngredients];
            for (int i = 0; i < MaxNumOfIngredients; i++)
                updatedList[i] = string.Empty;

            int pos = 0;
            for (int i = 0; i < MaxNumOfIngredients; i++)
            {
                if (! string.IsNullOrEmpty(Ingredients[i]))
                {
                    updatedList[pos] = Ingredients[i];
                    pos++;
                }
            }
            Ingredients = updatedList;
        }

        public Recipe Clone()
        // Return a clone of this recipe.
        {
            Recipe recipe = new Recipe(MaxNumOfIngredients)
            {
                Name = Name,
                Description = Description,
                Category = Category
            };
            for (int i = 0; i < Ingredients.Length; i++)
            {
                recipe.Ingredients[i] = Ingredients[i];
            }
            return recipe;
        }

        public void SetCopyOf(Recipe original)
        // Set the contents of this recipe to be that of the parameter given.
        {
            Name = original.Name;
            Description = original.Description;
            Category = original.Category;
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i] = original.Ingredients[i];
            }
        }
    }
}

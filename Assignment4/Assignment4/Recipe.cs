using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Recipe
    {
        // Instance variables
        private FoodCategory category;
        private string description;
        private string[] ingredientArray;
        private string name;

        public Recipe(int maxNumOfIngredients)
        {
            ingredientArray = new string[maxNumOfIngredients];
            DefaultValues();
        }

        // Properties
        public FoodCategory Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public string[] Ingredients { get => ingredientArray; set => ingredientArray = value; }
        public string Name { get => name; set => name = value; }
        public int MaxNumOfIngredients { get => ingredientArray.Length;  }

        // TODO: properties CurrentNumOfIngredients, MaxNumOfIngredients


        // Methods
        public bool AddIngredient(string value)
        {          
            int firstSlot = FindVacantPosition();
            if (firstSlot == -1)
                return false;
            else
            {
                ingredientArray[firstSlot] = value;
                return true;
            }                
        }
        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                ingredientArray[index] = value;
                return true;
            }
            else
                return false;
        }

        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < MaxNumOfIngredients);
        }

        public void DefaultValues()
        {
            for (int i= 0; i < ingredientArray.Length; i++)
            {
                ingredientArray[i] = string.Empty;
            }
            name = string.Empty;
            category = FoodCategory.Vegetarian;
            description = string.Empty;
        }

        public int FindVacantPosition()
        {
            int foundSlot = -1;
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (string.IsNullOrEmpty(ingredientArray[i]))
                {
                    return i;
                }
            }
            return foundSlot;
            // throw new NotImplementedException();
        }

        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText =  "No description";

            string textOut = $"{name, -20} {CurrentNumOfIngredients(),4}      {category.ToString(), -12}   {descriptionText, -15}";

            return textOut;
        }

        public int CurrentNumOfIngredients()
        {
            int count = 0;
            for (int i = 0; i < MaxNumOfIngredients; i++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[i]))
                    count += 1;
            }
            return count;
        }

        public bool DeleteIngredientAt(int index)
        {
            bool result = CheckIndex(index);
            if (result)
                ingredientArray[index] = string.Empty;
            return result;
        }
    }
}

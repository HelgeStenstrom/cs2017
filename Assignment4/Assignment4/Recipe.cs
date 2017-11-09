using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Assignment4
{
    public class Recipe
    {
        // Instance variables

        public Recipe(int maxNumOfIngredients)
        {
            Ingredients = new string[maxNumOfIngredients];
            DefaultValues();
        }

        // Properties
        // TODO: stega igenom programmet och kolla att dessa fungerar.
        public FoodCategory Category { get; set; }

        public string Description { get; set; }

        public string[] Ingredients { get; set; }

        public string Name { get; set; }

        public int MaxNumOfIngredients => Ingredients.Length;

        // TODO: properties CurrentNumOfIngredients, MaxNumOfIngredients


        // Methods
        public bool AddIngredient(string value)
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
        {
            if (CheckIndex(index))
            {
                Ingredients[index] = value;
                return true;
            }
            else
                return false;
        }

        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < MaxNumOfIngredients);
        }

        private void DefaultValues()
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
        {
            int chars = Math.Min(Description.Length, 15);
            string descriptionText = Description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText =  "No description";

            string textOut = $"{Name, -20} {CurrentNumOfIngredients(),4}      {Category.ToString(), -12}   {descriptionText, -15}";

            return textOut;
        }

        public int CurrentNumOfIngredients()
        {
            int count = 0;
            for (int i = 0; i < MaxNumOfIngredients; i++)
            {
                if (!string.IsNullOrEmpty(Ingredients[i]))
                    count += 1;
            }
            return count;
        }

        public bool DeleteIngredientAt(int index)
        {
            bool result = CheckIndex(index);
            if (result)
                Ingredients[index] = string.Empty;
            Repack();
            return result;
        }

        public void Repack()
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class RecipeManager
    {
        private int numberOfSlots;

        public int NumOfItems { get; set; }

        public RecipeManager(int numberOfSlots)
        {
            this.numberOfSlots = numberOfSlots;
        }

        public bool Add(string v1, FoodCategory fish, string[] v2)
        {
            throw new NotImplementedException();
        }

        public string[] RecipeListToString()
        {
            throw new NotImplementedException();
        }

        public bool Add(Recipe r)
        {
            throw new NotImplementedException();
        }

        public int GetCurrentNumOfItems()
        {
            throw new NotImplementedException();
        }

        public bool DeleteElement(int v)
        {
            throw new NotImplementedException();
        }

        public string[] GetIngredients(int v)
        {
            throw new NotImplementedException();
        }

        public Recipe GetRecipeAt(int v)
        {
            throw new NotImplementedException();
        }

        public bool ChangeElement(int v, Recipe r2)
        {
            throw new NotImplementedException();
        }
    }
}

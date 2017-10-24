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
        private int numberOfItems;
        private Recipe[] recipeList;

        public RecipeManager(int maxNumOfElements)
        {
        }

        // Properties
        public int NumOfItems { get => numberOfItems;  }

        // Public methods
        public bool Add(Recipe newRecipe)
        {
            throw new NotImplementedException();
        }

        public bool Add(string name, string[] ingredients)
        {
            throw new NotImplementedException();
        }

        public string[] GetIngredients(int index)
        {
            throw new NotImplementedException();
        }

     

        // Private methods
    }
}

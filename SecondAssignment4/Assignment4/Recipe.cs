using System;

namespace Assignment4
{
    public class Recipe
    {
        private int v;

        public Recipe(int v)
        {
            this.v = v;
        }

        public string[] Ingredients { get; set; }
        public FoodCategory Category { get; set; }
        public string Description { get; set; }
        public int MaxNumOfIngredients { get; set; }
        public string Name { get; set; }

        public int FindVacantPosition()
        {
            throw new NotImplementedException();
        }

        public bool AddIngredient(string v)
        {
            throw new NotImplementedException();
        }

        public bool CheckIndex(int v)
        {
            throw new NotImplementedException();
        }

        public int CurrentNumOfIngredients()
        {
            throw new NotImplementedException();
        }

        public bool ChangeIngredientAt(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIngredientAt(int idx)
        {
            throw new NotImplementedException();
        }

        public void Repack()
        {
            throw new NotImplementedException();
        }
    }
}
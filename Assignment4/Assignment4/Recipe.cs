﻿using System;
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
        }

        // Properties
        public FoodCategory Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public string[] Ingredients { get => ingredientArray; set => ingredientArray = value; }
        public string Name { get => name; set => name = value; }

        // TODO: properties CurrentNumOfIngredients, MaxNumOfIngredients


        // Methods
        public bool AddIngredient(string value)
        {
            throw new NotImplementedException();
        }
        public bool ChangeIngredientAt(int index, string value)
        {
            throw new NotImplementedException();
        }

        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void DefaultValues() { }

        public int FindVacantPost()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}

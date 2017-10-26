﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class FormMain : Form
    {
        // Allocation of space for ingredients and recipes
        private const int maxNumberOfIngredients = 20;
        private const int maxNumberOfRecipes = 50;

        // A recipe object to work with
        Recipe currentRecipe = new Recipe(maxNumberOfIngredients);

        // The recipe manager
        RecipeManager recipeManager = new RecipeManager(maxNumberOfRecipes);

        public FormMain()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            lstbxRecipes.Items.Clear();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            FormIngredients dlg = new FormIngredients(currentRecipe);
            DialogResult dialogResult = dlg.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (currentRecipe.CurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified!");
                    recipeManager.Add(currentRecipe);
                    UpdateGui();
                }
            }            
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {

        }

        private void UpdateGui()
        {
            recipeManager.Add(currentRecipe);
            //lstbxRecipes.Items.Add("First row");
            //lstbxRecipes.Items.Add("Second row");
            string[] ingreds = recipeManager.RecipeListToString();
            for (int i = 0; i < recipeManager.GetCurrentNumOfItems(); i++)
            {
                lstbxRecipes.Items.Add(ingreds[i]);
            }
            //lstbxRecipes.Items = recipeManager.RecipeListToString();
            throw new NotImplementedException();
        }
    }
}

using System;
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
        Recipe currentRecip = new Recipe(maxNumberOfIngredients);

        // The recipe manager
        RecipeManager recipeManager = new RecipeManager(maxNumberOfRecipes);

        public FormMain()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            throw new NotImplementedException();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            FormIngredients dlg = new FormIngredients(currentRecip);
            throw new NotImplementedException();
        }

    }
}

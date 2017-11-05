using System;
using System.Media;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class FormMain : Form
    {
        // Allocation of space for ingredients and recipes
        private const int MaxNumberOfIngredients = 20;
        private const int MaxNumberOfRecipes = 50;

        // A recipe object to work with
        Recipe _currentRecipe = new Recipe(MaxNumberOfIngredients);

        // The recipe manager
        readonly RecipeManager _recipeManager = new RecipeManager(MaxNumberOfRecipes);

        public FormMain()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            lstbxRecipes.Items.Clear();
            lblRecipeListHeader.Text = "Name               # ingr.    Cat.           Description ";
            comboBoxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
            // Code from assignment document
        {
            FormIngredients dlg = new FormIngredients(_currentRecipe);
            DialogResult dialogResult = dlg.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (_currentRecipe.CurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified!");
                    UpdateGui();
                }
            }            
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            ReadInputsForCurrentRecipe();
            _recipeManager.Add(_currentRecipe);
            UpdateGui();
        }

        private void ReadInputsForCurrentRecipe()
        {
            _currentRecipe.Name = txtRecipeName.Text;
            _currentRecipe.Description = txtDescription.Text;

            Enum.TryParse<FoodCategory>(comboBoxCategory.SelectedValue.ToString(), out var cat);
            _currentRecipe.Category = cat;
        }

        private void UpdateGui()
        {
            lstbxRecipes.Items.Clear();
            string[] ingreds = _recipeManager.RecipeListToString();
            for (int i = 0; i < _recipeManager.GetCurrentNumOfItems(); i++)
            {
                lstbxRecipes.Items.Add(ingreds[i]);
            }

            txtRecipeName.Text = _currentRecipe.Name;
            txtDescription.Text = _currentRecipe.Description;
            comboBoxCategory.SelectedItem = _currentRecipe.Category;
            //            comboBoxCategory.SelectedValue = _currentRecipe.Category;
            //SystemSounds.Beep.Play();
            Console.Beep();
            Console.Beep(500, 1000);
        }

        private void txtRecipeName_TextChanged(object sender, EventArgs e)
        {
            _currentRecipe.Name = txtRecipeName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            _currentRecipe.Description = txtDescription.Text;
        }

        private void lstbxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lstbxRecipes.SelectedIndex;
            Recipe rSel = _recipeManager.GetRecipeAt(selected);
            _currentRecipe = rSel;
            UpdateGui();
        }
    }
}

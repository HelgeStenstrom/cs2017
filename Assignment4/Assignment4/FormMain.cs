using System;
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
            ReadInputsForCurrentRecipe();
            FormIngredients dlg = new FormIngredients(_currentRecipe);
            DialogResult dialogResult = dlg.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (_currentRecipe.CurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified!");
                    // UpdateGui();  // Do this regardless of success or not.
                }
            }

            // This is not from the assignment, but it's reasonable:
            UpdateGuiLeft();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            ReadInputsForCurrentRecipe();
            Recipe toAdd = _currentRecipe.Clone();
            _recipeManager.AddOld(toAdd);
            
            _currentRecipe = new Recipe(MaxNumberOfIngredients);
            UpdateGuiLeft();
            UpdateRecipeList();
        }

        private void ReadInputsForCurrentRecipe()
        {
            _currentRecipe.Name = txtRecipeName.Text;
            _currentRecipe.Description = txtDescription.Text;

            Enum.TryParse<FoodCategory>(comboBoxCategory.SelectedValue.ToString(), out var cat);
            _currentRecipe.Category = cat;
        }

        private void UpdateGuiLeft()
        {

            txtRecipeName.Text = _currentRecipe.Name;
            txtDescription.Text = _currentRecipe.Description;
            comboBoxCategory.SelectedItem = _currentRecipe.Category;

            Console.Beep();
        }

        private void UpdateRecipeList()
        {
            lstbxRecipes.Items.Clear();
            string[] recipeTexts = _recipeManager.RecipeListToString();
            lstbxRecipes.Items.AddRange(recipeTexts);

            Console.Beep(500, 500);
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
            if (!(rSel == null))
            {
                _currentRecipe = rSel.Clone();
                UpdateGuiLeft();
            }                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selected = lstbxRecipes.SelectedIndex;
            if (selected < 0)
            {
                Console.Beep(400, 600);
            }
            else
            {
                _recipeManager.DeleteRecipe(selected);
                UpdateRecipeList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

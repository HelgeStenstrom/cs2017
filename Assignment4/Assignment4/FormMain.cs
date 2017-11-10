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
        // The constructor of the form. The first call is mandatory and put there by Visual Studio.
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        // Run only once during the lifetime of the program.
        // The things that are done here could equally well have been put in their respective 
        // components when the form was drawn.
        {
            lstbxRecipes.Items.Clear(); // Start with an empty recipe list
            // The header matches the rows that will appear in the form.
            lblRecipeListHeader.Text = "Name               # ingr.    Cat.           Description ";
            // Selectable values in the cyclic field for recipe type.
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
        // The user wants to add a recipe to the list of recipes.
        {
            ReadInputsForCurrentRecipe();
            // We want to add a copy of the current recipe into the list, an not the same recipe.
            Recipe toAdd = _currentRecipe.Clone();
            // AddOld means add an existing recipe. We create the specific recipe on the row above,
            // and put it (yes, it, not a copy) in the recipe list in the row below.
            _recipeManager.AddOld(toAdd);
            
            // Renew the current recipe. We don't need the old one.
            _currentRecipe = new Recipe(MaxNumberOfIngredients);
            UpdateGuiLeft();
            UpdateRecipeList();
        }

        private void ReadInputsForCurrentRecipe()
        // Copy the relevant GUI settings into the current recipe.
        {
            _currentRecipe.Name = txtRecipeName.Text;
            _currentRecipe.Description = txtDescription.Text;

            Enum.TryParse<FoodCategory>(comboBoxCategory.SelectedValue.ToString(), out var cat);
            _currentRecipe.Category = cat;
        }

        private void UpdateGuiLeft()
        // Update all GUI parts except the recipe list on the right side.
        {

            txtRecipeName.Text = _currentRecipe.Name;
            txtDescription.Text = _currentRecipe.Description;
            comboBoxCategory.SelectedItem = _currentRecipe.Category;

            preview.Items.Clear();
            preview.Items.AddRange(_currentRecipe.Ingredients);
            // Enable the row below to hear when the GUI is updated. For development and understanding.
            //  Console.Beep();
        }

        private void UpdateRecipeList()
        {
            lstbxRecipes.Items.Clear();
            string[] recipeTexts = _recipeManager.RecipeListToString();
            lstbxRecipes.Items.AddRange(recipeTexts);

            // Enable the row below to hear when the recipe list of the GUI is updated. For development and understanding.
           // Console.Beep(500, 500);
        }

        private void txtRecipeName_TextChanged(object sender, EventArgs e)
        // When the test name is written, we update the name of the current recipe, character by character. 
        {
            _currentRecipe.Name = txtRecipeName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        // When the test description is written, we update the description of the current recipe, character by character.
        {
            _currentRecipe.Description = txtDescription.Text;
        }

        private void lstbxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        // When a recipe in the recipe list is selected, copy that recipe into the current recipe.
        // Update the GUI, so that the recipe's description, name and category are displayed.
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
        // When Delete is clicked, the marked recipe is deleted from the recipe lists of the GUI and recipe manager, respectively.
        {
            int selected = lstbxRecipes.SelectedIndex;
            if (selected < 0)
            {
               //  Console.Beep(400, 600);
            }
            else
            {
                _recipeManager.DeleteRecipe(selected);
                UpdateRecipeList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        // When Edit is clicked, the marked recipe is replaced by the current recipe. 
        // This is similar to Add, except that the recipe list doesn't get longer.
        {
            int selected = lstbxRecipes.SelectedIndex;
            if (selected < 0)
            {
                // Console.Beep(400, 600);
            }
            else
            {
                ReadInputsForCurrentRecipe();
                _recipeManager.GetRecipeAt(selected).setCopyOf(_currentRecipe);
                UpdateRecipeList();
            }
        }    

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        // Do nothing. The combo box is read when needed. 
        // We could set the category of the current recipe, but it wouldn't help, since we 
        // anyway must handle the situation that the user is satisfied with the current setting,
        // and thus won't generate a SelectedIndexChanged event.
        {
            // Do nothing.
        }
    }
}

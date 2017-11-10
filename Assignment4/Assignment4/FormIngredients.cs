using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace Assignment4
{
    public partial class FormIngredients : Form
    {
        // We have two recipes in this class. This is to enable canceling the edit. 
        private readonly Recipe _workRecipe;
        private readonly Recipe _originalRecipe;


        /// <summary>
        /// Form/window used to edit the list of ingredients in a recipe.
        /// </summary>
        /// <param name="recipe">The recipe that the form works on.</param>
        public FormIngredients(Recipe recipe)
        // The constructor takes a recipe to work with as an argument.
        {
            InitializeComponent();

            // my initialization
            _originalRecipe = recipe;
            _workRecipe = recipe.Clone();  // A new name for the recipe, so that it can be used by the whole class.
            InitializeGui();
        }

        private void InitializeGui()
        // Basically copied from the Assignment 4 help document.
        // It doesn't feel good to test for null, or 
        // having a Recipe object that can have null properties.
        {
            // The Recipe class cannot have Ingredients == null, because of
            // how it is initialized. If that appears to be false, we will
            // let an exception happen, and then fix the bug.
            // No need to test for null, therefore.
            
            if (string.IsNullOrEmpty(_workRecipe.Name))
                Text = "No Recipe Name";
            else
                Text = _workRecipe.Name + " Add ingredients";
            
            toolTipIngredients.SetToolTip(txtIngredient, "Example: 2 dl milk");
            UpdateGui();
        }

        private void UpdateGui()
        // Updates all visible changeable parts of the GUI, with information from the working recipe.
        {
            txtIngredient.Clear(); // We don't want to fill this from the working recipe
            lblNumberIngred.Text = $"Number of ingredients: {_workRecipe.CurrentNumOfIngredients}";

            // Clear the ingredients list and fill it from the recipe object.
            lstIngredients.Items.Clear();
            lstIngredients.Items.AddRange(_workRecipe.Ingredients); // This is risky. 
            txtIngredient.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        // When we are done and OK, we update the recipe that the form was called with.
        // Compare this with Cancel
        {
            _originalRecipe.SetCopyOf(_workRecipe);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        // When we click Cancel, we will exit the form, but we don't want to  update the recipe that the 
        // form was called with.
        // Compare this with OK.
        {
            // Noting to do.
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        // The ingredient that is in the entry text box is copied into the recipe.
        {
            string ingredient = txtIngredient.Text;
            _workRecipe.AddIngredient(ingredient);
            UpdateGui();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        // The ingredient that is selected replaced with what is in the ingredient text box
        {
            int selected = lstIngredients.SelectedIndex;
            _workRecipe.Ingredients[selected] = txtIngredient.Text;
            UpdateGui();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        // The ingredient that is selected is deleted from the recipe.
        {
            int selected = lstIngredients.SelectedIndex;
            _workRecipe.DeleteIngredientAt(selected);
            UpdateGui();
        }

        private void txtIngredient_KeyPress(object sender, KeyPressEventArgs e)
        // When the Enter key is pressed, do the same thing as when the Add button is clicked.
        {
            if (e.KeyChar == '\r')
            {
                btnAdd_Click(sender, e);
                // https://stackoverflow.com/questions/6290967/stop-the-ding-when-pressing-enter
                e.Handled = true;
            }
        }

    }
}

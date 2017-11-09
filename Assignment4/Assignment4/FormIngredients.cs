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
        // This field is not private. Should it?
        // The general recommendation is to have all fields private.
        // The example in Assignment 4 Help, page 17 is non-private.
        readonly Recipe _workRecipe;
        private Recipe _originalRecipe;

        // Properties
        public ToolTip tooltip => toolTipIngredients;

        public FormIngredients(Recipe recipe)
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
        {

            txtIngredient.Clear();
            lblNumberIngred.Text = $"Number of ingredients: {_workRecipe.CurrentNumOfIngredients()}";
            lblNumberIngred.Text = $"Number of ingredients: {_workRecipe.CurrentNumOfIngredients()}";

            lstIngredients.Items.Clear();
            lstIngredients.Items.AddRange(_workRecipe.Ingredients);
            txtIngredient.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _originalRecipe.setCopyOf(_workRecipe);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ingredient = txtIngredient.Text;
            _workRecipe.AddIngredient(ingredient);
            UpdateGui();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selected = lstIngredients.SelectedIndex;
            _workRecipe.Ingredients[selected] = txtIngredient.Text;
            UpdateGui();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selected = lstIngredients.SelectedIndex;
            _workRecipe.DeleteIngredientAt(selected);
            UpdateGui();
        }

        private void txtIngredient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAdd_Click(sender, e);
                // https://stackoverflow.com/questions/6290967/stop-the-ding-when-pressing-enter
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Noting to do.
        }
    }
}

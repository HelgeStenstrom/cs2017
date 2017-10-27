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
    public partial class FormIngredients : Form
    {
        // This field is not private. Should it?
        // The general recommendation is to have all fields private.
        // The example in Assignment 4 Help, page 17 is non-private.
        Recipe recipe;

        // Properties
        public ToolTip Tt { get => toolTipIngredients; }

        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();

            // my initialization
            this.recipe = recipe;
            if (string.IsNullOrEmpty(recipe.Name))
                this.Text = "No Recipe Name";
            else
                this.Text = recipe.Name + " Add ingredients";
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
            
            toolTipIngredients.SetToolTip(txtIngredient, "Example: 2 dl milk");
            UpdateGui();
        }

        private void UpdateGui()
        {
            lstIngredients.Items.Clear();
            txtIngredient.Clear();
            lblNumberIngred.Text = $"Number of ingredients: {recipe.CurrentNumOfIngredients()}";
            for (int i = 0; i < recipe.CurrentNumOfIngredients(); i++)
            {
                if (recipe.CheckIndex(i))
                    lstIngredients.Items.Add(recipe.Ingredients[i]);
            }
            txtIngredient.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ingredient = txtIngredient.Text;
            recipe.AddIngredient(ingredient);
            UpdateGui();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selected = lstIngredients.SelectedIndex;
            recipe.DeleteIngredientAt(selected);
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
    }
}

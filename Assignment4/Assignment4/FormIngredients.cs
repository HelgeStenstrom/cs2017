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
            lstIngredients.Items.Clear();
            toolTipIngredients.SetToolTip(txtIngredient, "Example: 2 dl milk");
            lblNumberIngred.Text = $"Number of ingredients: {recipe.CurrentNumOfIngredients()}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        Recipe recipe;


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
        {
            if (recipe.Ingredients == null)
                recipe.Ingredients = new string[recipe.MaxNumOfIngredients];
            lstIngredients.Items.Clear();
            // TODO: A tool tip may go here
            lblNumberIngred.Text = $"Number of ingredients: {recipe.CurrentNumOfIngredients()}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace Assignment4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbAddNewRecipe = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstbxRecipes = new System.Windows.Forms.ListBox();
            this.lblRecipeListHeader = new System.Windows.Forms.Label();
            this.grpbAddNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbAddNewRecipe
            // 
            this.grpbAddNewRecipe.Controls.Add(this.txtDescription);
            this.grpbAddNewRecipe.Controls.Add(this.btnAddIngredient);
            this.grpbAddNewRecipe.Controls.Add(this.comboBox1);
            this.grpbAddNewRecipe.Controls.Add(this.textBox1);
            this.grpbAddNewRecipe.Controls.Add(this.lblCategory);
            this.grpbAddNewRecipe.Controls.Add(this.lblNameOfRecipe);
            this.grpbAddNewRecipe.Location = new System.Drawing.Point(13, 13);
            this.grpbAddNewRecipe.Name = "grpbAddNewRecipe";
            this.grpbAddNewRecipe.Size = new System.Drawing.Size(399, 310);
            this.grpbAddNewRecipe.TabIndex = 0;
            this.grpbAddNewRecipe.TabStop = false;
            this.grpbAddNewRecipe.Text = "Add new recipe";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(7, 115);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(386, 179);
            this.txtDescription.TabIndex = 4;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(263, 60);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(130, 23);
            this.btnAddIngredient.TabIndex = 3;
            this.btnAddIngredient.Text = "Add ingredients";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 63);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblNameOfRecipe
            // 
            this.lblNameOfRecipe.AutoSize = true;
            this.lblNameOfRecipe.Location = new System.Drawing.Point(7, 31);
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            this.lblNameOfRecipe.Size = new System.Drawing.Size(79, 13);
            this.lblNameOfRecipe.TabIndex = 0;
            this.lblNameOfRecipe.Text = "Name of recipe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Recipe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstbxRecipes
            // 
            this.lstbxRecipes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxRecipes.FormattingEnabled = true;
            this.lstbxRecipes.ItemHeight = 14;
            this.lstbxRecipes.Location = new System.Drawing.Point(418, 73);
            this.lstbxRecipes.MultiColumn = true;
            this.lstbxRecipes.Name = "lstbxRecipes";
            this.lstbxRecipes.Size = new System.Drawing.Size(371, 284);
            this.lstbxRecipes.TabIndex = 2;
            // 
            // lblRecipeListHeader
            // 
            this.lblRecipeListHeader.AutoSize = true;
            this.lblRecipeListHeader.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeListHeader.Location = new System.Drawing.Point(421, 44);
            this.lblRecipeListHeader.Name = "lblRecipeListHeader";
            this.lblRecipeListHeader.Size = new System.Drawing.Size(294, 14);
            this.lblRecipeListHeader.TabIndex = 3;
            this.lblRecipeListHeader.Text = "Recipe No of ingred. Cateogry Description";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 455);
            this.Controls.Add(this.lblRecipeListHeader);
            this.Controls.Add(this.lstbxRecipes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpbAddNewRecipe);
            this.Enabled = false;
            this.Name = "FormMain";
            this.Text = "Apu\'s Cook Book";
            this.grpbAddNewRecipe.ResumeLayout(false);
            this.grpbAddNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbAddNewRecipe;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblNameOfRecipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstbxRecipes;
        private System.Windows.Forms.Label lblRecipeListHeader;
    }
}


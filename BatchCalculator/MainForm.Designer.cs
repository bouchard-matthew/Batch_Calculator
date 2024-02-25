using BatchCalculator.Services;

namespace BatchCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private RecipeService _recipeService = new();

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productDropdown = new ComboBox();
            productLabel = new Label();
            scaledRecipe = new RichTextBox();
            clearButton = new Button();
            ingredientsLabel = new Label();
            quantityLabel = new Label();
            quantityDropdown = new ComboBox();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // productDropdown
            // 
            productDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            productDropdown.FormattingEnabled = true;
            productDropdown.Items.AddRange(_recipeService.GetRecipeNames().ToArray());
            productDropdown.Location = new Point(279, 87);
            productDropdown.Name = "productDropdown";
            productDropdown.Size = new Size(206, 23);
            productDropdown.TabIndex = 0;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(221, 90);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(52, 15);
            productLabel.TabIndex = 1;
            productLabel.Text = "Product:";
            // 
            // scaledRecipe
            // 
            scaledRecipe.Location = new Point(279, 174);
            scaledRecipe.Name = "scaledRecipe";
            scaledRecipe.Size = new Size(206, 225);
            scaledRecipe.TabIndex = 2;
            scaledRecipe.Text = "";
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearButton.Location = new Point(382, 145);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(103, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += HideTextBox;
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Location = new Point(204, 174);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(69, 15);
            ingredientsLabel.TabIndex = 4;
            ingredientsLabel.Text = "Ingredients:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(217, 119);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(56, 15);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityDropdown
            // 
            quantityDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            quantityDropdown.FormattingEnabled = true;
            quantityDropdown.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            quantityDropdown.Location = new Point(279, 116);
            quantityDropdown.Name = "quantityDropdown";
            quantityDropdown.Size = new Size(206, 23);
            quantityDropdown.TabIndex = 6;
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            calculateButton.Location = new Point(279, 145);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(97, 23);
            calculateButton.TabIndex = 7;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += CalculateButtonClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateButton);
            Controls.Add(quantityDropdown);
            Controls.Add(quantityLabel);
            Controls.Add(ingredientsLabel);
            Controls.Add(clearButton);
            Controls.Add(scaledRecipe);
            Controls.Add(productLabel);
            Controls.Add(productDropdown);
            Name = "MainForm";
            Text = "Batch Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
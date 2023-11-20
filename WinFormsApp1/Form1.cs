using System.Diagnostics;
using BatchCalculator.Models;
using BatchCalculator.Models.Breads;

namespace BatchCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ComboBox productDropdown;
        private Label productLabel;
        private RichTextBox scaledRecipe;
        private Button clearButton;
        private Label ingredientsLabel;
        private Label quantityLabel;
        private ComboBox quantityDropdown;
        private Button calculateButton;

        private void HideTextBox(object sender, EventArgs e)
        {
            scaledRecipe.Text = "";
            ingredientsLabel.Hide();
            scaledRecipe.Hide();
        }

        private void CalculateButtonClicked(object sender, EventArgs e)
        {
            scaledRecipe.ResetText();

            switch (productDropdown.Text)
            {
                case "Rosemary":
                    scaledRecipe.Text = new Rosemary().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
                case "Cheddar Italian":
                    scaledRecipe.Text = new CheddarItalian().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
                case "Tomato Basil":
                    scaledRecipe.Text = new TomatoBasil().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
                case "Cranberry Walnut":
                    scaledRecipe.Text = new CranberryWalnut().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
                case "Mountain Herb":
                    scaledRecipe.Text = new MountainHerb().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
                case "Farmhouse Molasses":
                    scaledRecipe.Text = new Molasses().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
                case "Hippie Loaf":
                    scaledRecipe.Text = new HippieLoaf().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
                case "Triple Chocolate":
                    scaledRecipe.Text = new TripleChocolate().Batch(quantityDropdown.SelectedIndex + 1);
                    break;
            }

            scaledRecipe.Show();
            ingredientsLabel.Show();
        }
    }
}

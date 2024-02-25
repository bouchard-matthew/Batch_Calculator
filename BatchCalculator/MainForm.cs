using BatchCalculator.Services;
using BatchCalculator.Utils;

namespace BatchCalculator
{
    public partial class MainForm : Form
    {
        private ComboBox productDropdown;
        private Label productLabel;
        private RichTextBox scaledRecipe;
        private Button clearButton;
        private Label ingredientsLabel;
        private Label quantityLabel;
        private ComboBox quantityDropdown;
        private Button calculateButton;

        public MainForm()
        {
            InitializeComponent();
            _recipeService = new RecipeService();
        }

        private void HideTextBox(object sender, EventArgs e)
        {
            scaledRecipe.Text = "";
            ingredientsLabel.Hide();
            scaledRecipe.Hide();
        }

        private void CalculateButtonClicked(object sender, EventArgs e)
        {
            scaledRecipe.ResetText();

            string outputText = "";
            int quantity = quantityDropdown.SelectedIndex + 1;

            _recipeService.GetRecipeByName(productDropdown.Text).Ingredients.ForEach(i =>
            {
                outputText += NameHandler.FormatName(i.Name) + " " + ConversionHandler.ScaleIngredient(i, quantity) + " \n";
            });

            scaledRecipe.Text = outputText;

            scaledRecipe.Show();
            ingredientsLabel.Show();
        }
    }
}

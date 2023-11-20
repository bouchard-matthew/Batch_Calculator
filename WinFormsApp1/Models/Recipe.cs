using BatchCalculator.Interfaces;

namespace BatchCalculator.Models
{
    class Recipe
    {
        public IIngredient[] Ingredients { get; set; }

        public Recipe()
        {
            Ingredients = Array.Empty<IIngredient>();
        }
        public string Batch(int scale)
        {
            string output = string.Empty;

            if (Ingredients == null) return output;

            foreach(IIngredient ingredient in Ingredients)
            {
                output += ingredient.SetScale(scale).ToString();
            }

            return output;
        }
    }
}

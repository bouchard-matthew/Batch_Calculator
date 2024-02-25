using static BatchCalculator.Enums.Enums;

namespace BatchCalculator.Models
{
    public class Recipe
    {
        public string Name { get; set; } = "";
        public Category Category { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new() { };
    }
}

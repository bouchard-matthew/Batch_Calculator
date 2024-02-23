using static BatchCalculator.Enums.Enums;

namespace BatchCalculator.Interfaces
{
    public interface IRecipe
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<IIngredient> Ingredients { get; set; }
    }
}

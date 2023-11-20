using BatchCalculator.Interfaces;
using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models.Breads
{
    internal class CheddarItalian : Recipe
    {
        public CheddarItalian() : base()
        {
            Ingredients = new IIngredient[]
            {
                Factory.Factory.CreateIngredient("initialFlour", 1, Units.Cup),
                Factory.Factory.CreateIngredient("sugar", 4, Units.Tbsp),
                Factory.Factory.CreateIngredient("yeast", 2, Units.Tbsp),
                Factory.Factory.CreateIngredient("water", 1.75, Units.Cup),
                Factory.Factory.CreateIngredient("butter", 2, Units.Tbsp),
                Factory.Factory.CreateIngredient("seasoning", 1, Units.Tsp),
                Factory.Factory.CreateIngredient("salt", 2, Units.Tsp, "salt"),
                Factory.Factory.CreateIngredient("mainFlour", 4, Units.Cup)
            };
        }
    }
}
using BatchCalculator.Interfaces;
using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models.Breads
{
    internal class TripleChocolate : Recipe
    {
        public TripleChocolate() : base()
        {
            Ingredients = new IIngredient[]
            {
                Factory.Factory.CreateIngredient("initialFlour", 2, Units.Cup),
                Factory.Factory.CreateIngredient("salt", 0.5, Units.Tsp),
                Factory.Factory.CreateIngredient("sugar", 1, Units.Cup),
                Factory.Factory.CreateIngredient("cocoaPowder", 3, Units.Tbsp),
                Factory.Factory.CreateIngredient("bakingPowder", 1, Units.Tbsp),
                Factory.Factory.CreateIngredient("egg", 1, Units.Whole),
                Factory.Factory.CreateIngredient("milk", 1.25, Units.Cup),
                Factory.Factory.CreateIngredient("oliveOil", 0.5, Units.Cup),
                Factory.Factory.CreateIngredient("semiSweetChocolateChips", 1, Units.Cup),
                Factory.Factory.CreateIngredient("milkChocolateChips", 1, Units.Cup),
                Factory.Factory.CreateIngredient("whiteChocolateChips", 1, Units.Cup)
            };
        }
    }
}

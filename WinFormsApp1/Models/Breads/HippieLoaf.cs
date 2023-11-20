using BatchCalculator.Interfaces;
using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models.Breads
{
    internal class HippieLoaf : Recipe
    {
        public HippieLoaf() : base()
        {
            Ingredients = new IIngredient[]
            {
                Factory.Factory.CreateIngredient("initialFlour", 3.5, Units.Cup),
                Factory.Factory.CreateIngredient("salt", 1, Units.Tsp),
                Factory.Factory.CreateIngredient("hempHearts", 0.25, Units.Cup),
                Factory.Factory.CreateIngredient("sunflowerSeeds", 0.25, Units.Cup),
                Factory.Factory.CreateIngredient("pumpkinSeeds", 0.25, Units.Cup),
                Factory.Factory.CreateIngredient("chiaSeeds", 1, Units.Cup),
                Factory.Factory.CreateIngredient("quickOats", 1, Units.Cup, "quickOats"),
                Factory.Factory.CreateIngredient("boilingWater", 1.5, Units.Cup),
                Factory.Factory.CreateIngredient("sugar", 1, Units.Tsp, "sugar"),
                Factory.Factory.CreateIngredient("honey", 0.5, Units.Cup),
                Factory.Factory.CreateIngredient("water", 0.25, Units.Cup),
                Factory.Factory.CreateIngredient("yeast", 2, Units.Tsp)
            };
        }
    }
}

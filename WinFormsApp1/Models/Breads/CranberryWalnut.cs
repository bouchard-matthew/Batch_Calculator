using BatchCalculator.Interfaces;
using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models.Breads
{
    internal class CranberryWalnut : Recipe
    {
        public CranberryWalnut() : base()
        {
            Ingredients = new IIngredient[]
            {
                Factory.Factory.CreateIngredient("initialFlour", 1, Units.Cup),
                Factory.Factory.CreateIngredient("honey", 0.5, Units.Cup),
                Factory.Factory.CreateIngredient("yeast", 1, Units.Tsp),
                Factory.Factory.CreateIngredient("cinnamon", 1, Units.Tsp),
                Factory.Factory.CreateIngredient("water", 1.75, Units.Cup),
                Factory.Factory.CreateIngredient("craisins", 1, Units.Cup),
                Factory.Factory.CreateIngredient("walnuts", 1, Units.Cup),
                Factory.Factory.CreateIngredient("oliveOil", 0.25, Units.Cup),
                Factory.Factory.CreateIngredient("salt", 1.5, Units.Tsp, "salt"),
                Factory.Factory.CreateIngredient("mainFlour", 5, Units.Cup)
            };
        }
    }
}

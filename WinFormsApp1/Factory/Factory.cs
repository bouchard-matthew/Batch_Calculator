using BatchCalculator.Interfaces;
using BatchCalculator.Models;
using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Factory
{
    internal class Factory
    {
        public static IIngredient CreateIngredient(string name, double quantity, Units unit, string ingredientType = "ingredient", int scale = 1)
        {
            return ingredientType.ToLower() switch
            {
                "salt" => new Salt(name, quantity, unit, scale),
                "sugar" => new Sugar(name, quantity, unit, scale),
                "quickoats" => new QuickOats(name, quantity, unit, scale),
                _ => new Ingredient(name, quantity, unit, scale),
            };
        }
    }
}

using static BatchCalculator.Enums.Enums;
using BatchCalculator.Models;

namespace BatchCalculator.Utils
{
    public static class ConversionHandler
    {
        private static readonly Dictionary<Unit, double> _conversionFactors = new()
        {
            { Unit.Tsp, 1.0 },
            { Unit.Tbsp, 3.0 },
            { Unit.Cup, 48.0 },
        };

        public static string ScaleIngredient(Ingredient ingredient, int quantity)
        {
            if (ingredient.State == State.Wet)
            {
                return $"{ingredient.Quantity * quantity} {ingredient.Unit}";
            }

            return ConvertDryUnits(ingredient.Unit, (quantity * ingredient.Quantity));
        }

        public static string ConvertDryUnits(Unit originalUnit, double originalQuantity)
        {
            double scaledQuantity = originalQuantity * _conversionFactors.GetValueOrDefault(originalUnit);
            return ConvertTspToCupsTbspsTsps(scaledQuantity);
        }

        private static string ConvertTspToCupsTbspsTsps(double tspEquivalent)
        {
            return UnitConversionHandler.Convert(tspEquivalent);
        }
    }
}

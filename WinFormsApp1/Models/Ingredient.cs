using System.Text.RegularExpressions;
using BatchCalculator.Interfaces;
using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models
{
    internal class Ingredient : IIngredient
    {
        // Look into making this an enum
        private readonly string _name;
        private readonly double _quantity;
        private readonly Units _unit;
        private int _scale;

        public Ingredient(string name, double quantity, Units unit, int scale = 1)
        {
            _name = name;
            _quantity = quantity;
            _unit = unit;
            _scale = scale;
        }

        public Ingredient SetScale(int value)
        {
            _scale = value;
            return this;
        }

        public string GetDisplayName()
        {
            string formattedName = char.ToUpper(_name[0]) + _name[1..];
            Regex regex = new(@"(?<!^)(?=[A-Z])");
            string[] splitFormattedName = regex.Split(formattedName);
            string joinedFormattedName = string.Join(" ", splitFormattedName);
            return (joinedFormattedName + "\n");
        }

        public override string ToString()
        {
            double scaledQuantity = _scale * _quantity;

            if (_unit == Units.Whole) return (scaledQuantity).ToString() + $" {Units.Whole} {GetDisplayName()}";
            else if (scaledQuantity < 1 && _unit == Units.Tsp) return (scaledQuantity).ToString() + $" {Units.Tsp} {GetDisplayName()}";

            double tspEquivalent = ConversionUtility.ConvertToTsp(_unit, scaledQuantity);
            double[] convertedIngredientsArray = ConversionUtility.ConvertTspToCupsTbspsTsps(tspEquivalent);
            string formattedIngredients = FormatConvertedScaledIngredients(convertedIngredientsArray);
            return formattedIngredients + " " + GetDisplayName();
        }

        private static string FormatConvertedScaledIngredients(double[] measurements)
        {
            string output = String.Empty;

            double cups = measurements[0];
            double tbsps = measurements[1];
            double tsps = measurements[2];

            if (cups > 0) output += $"{cups} {Units.Cup}";
            if (tbsps > 0)
            {
                if (string.IsNullOrEmpty(output)) output += $"{tbsps} {Units.Tbsp}";
                else output += $" + {tbsps} {Units.Tbsp}";
            }
            if (tsps > 0)
            {
                if (string.IsNullOrEmpty(output)) output += $"{tsps} {Units.Tsp}";
                else output += $" + {tsps} {Units.Tsp}";
            }

            return output;
        }

    }
}

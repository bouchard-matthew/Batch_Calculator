using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models
{
    internal class QuickOats : Ingredient
    {
        public QuickOats(string name, double quantity, Units unit, int scale = 1)
            : base(name, quantity, unit, scale) { }

        public override string ToString() =>
            "\nSet Dry Ingredients Aside\nBoil Quick Oats using the Following Measurements: \n" + base.ToString();
    }
}

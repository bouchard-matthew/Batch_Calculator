using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models
{
    internal class Salt : Ingredient
    {
        public Salt(string name, double quantity, Units unit, int scale = 1)
            : base(name, quantity, unit, scale) { }

        public override string ToString() =>
            "\nThen, once the yeast has proofed, add: \n" + base.ToString();
    }
}

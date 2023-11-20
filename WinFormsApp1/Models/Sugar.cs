using Units = BatchCalculator.Enums.Enums.Units;

namespace BatchCalculator.Models
{
    internal class Sugar : Ingredient
    {
        public Sugar(string name, double quantity, Units unit, int scale = 1)
            : base(name, quantity, unit, scale) { }

        public override string ToString() =>
            "\nThen, you are going to add the following to a mixer bowl to prove: \n" + base.ToString();
    }
}

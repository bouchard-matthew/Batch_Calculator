
using static BatchCalculator.Enums.Enums;

namespace BatchCalculator.Models
{
    public class Ingredient
    {
        public string Name { get; set; } = "";
        public double Quantity { get; set; }
        public Unit Unit { get; set; }
        public State State { get; set; }
    }
}
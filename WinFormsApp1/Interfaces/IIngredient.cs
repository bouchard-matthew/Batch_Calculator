
using static BatchCalculator.Enums.Enums;

namespace BatchCalculator.Interfaces
{
    public interface IIngredient
    {
        string Name { get; }
        double Quantity { get; }
        Unit Unit { get; }
        State State { get; }
    }
}
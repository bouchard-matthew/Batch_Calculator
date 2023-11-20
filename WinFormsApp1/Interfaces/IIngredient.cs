using BatchCalculator.Models;

namespace BatchCalculator.Interfaces
{
    internal interface IIngredient
    {
        string GetDisplayName();
        Ingredient SetScale(int value);
        string ToString();
    }
}
using BatchCalculator.Models;

namespace BatchCalculator.Interfaces
{
    public interface IIngredient
    {
        string GetDisplayName();
        Ingredient SetScale(int value);
        string ToString();
        int GetScale();
    }
}
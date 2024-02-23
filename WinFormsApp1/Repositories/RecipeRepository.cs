using System.Diagnostics;
using BatchCalculator.Interfaces;
using BatchCalculator.Utils;

namespace BatchCalculator.Repositories
{
    public class RecipeRepository
    {
        private List<IRecipe> _recipes = new();

        public RecipeRepository() => GetFullRecipes();

        private void GetFullRecipes() => _recipes = JsonHandler.ReadRecipes() ?? new List<IRecipe>();
        public List<IRecipe> GetRecipes() => _recipes.ToList();
        public List<string> GetRecipeNames()
        {
            try
            {
                Debug.WriteLine(string.Join(", ", _recipes.Select(recipe => recipe.Name)));
                return _recipes.Select(recipe => recipe.Name).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading recipe names: {ex.Message}");
                return new List<string>();
            }
        }

        public void AddRecipe(IRecipe newRecipe)
        {
            JsonHandler.WriteRecipe(newRecipe);
            GetFullRecipes();
        }
    }
}

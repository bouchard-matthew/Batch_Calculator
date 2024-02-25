using System.Diagnostics;
using BatchCalculator.Models;
using BatchCalculator.Repositories;

namespace BatchCalculator.Services
{
    public class RecipeService
    {
        private List<Recipe> _recipes = new();
        public RecipeService()
        {
            InitializeRecipes();
        }
        private void InitializeRecipes()
        {
            _recipes = RecipeRepository.ReadRecipes();
        }

        public List<Recipe> GetRecipes() => _recipes.ToList();
        public List<string> GetRecipeNames() => _recipes.Select(recipe => recipe.Name).ToList() ?? new List<string>();
        public void AddRecipe(Recipe newRecipe)
        {
            RecipeRepository.WriteRecipe(newRecipe);
            InitializeRecipes();
        }
        public Recipe GetRecipeByName(string recipeName)
        {
            return GetRecipes().FirstOrDefault(recipe => recipe.Name == recipeName) ?? new Recipe();
        }
    }
}

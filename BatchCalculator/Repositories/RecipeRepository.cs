using BatchCalculator.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BatchCalculator.Repositories
{
    public static class RecipeRepository
    {
        private const string RecipeFilePath = "./recipes.json";

        public static List<Recipe> ReadRecipes()
        {
            try
            {
                string jsonText = File.ReadAllText(RecipeFilePath);
                var json = JObject.Parse(jsonText);
                var recipesPropPresent = json.TryGetValue("recipes", out var recipesToken);
                return recipesToken?.ToObject<List<Recipe>>() ?? new List<Recipe>();
            }
            catch (JsonSerializationException)
            {
                return new List<Recipe>();
            }
        }

        public static void WriteRecipe(Recipe recipe)
        {
            string jsonText = JsonConvert.SerializeObject(recipe, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(RecipeFilePath, jsonText);
        }
    }
}

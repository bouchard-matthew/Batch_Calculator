using System.Diagnostics;
using BatchCalculator.Interfaces;
using Newtonsoft.Json;

namespace BatchCalculator.Utils
{
    public static class JsonHandler
    {
        private const string _recipeFilePath = "./recipes.json";

        public static List<IRecipe> ReadRecipes()
        {
            try
            {
                string jsonText = File.ReadAllText(_recipeFilePath);
                var recipes = JsonConvert.DeserializeObject<List<IRecipe>>(jsonText, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
                return recipes ?? new List<IRecipe>();
            }
            catch (FileNotFoundException e)
            {
                return new List<IRecipe>();
            }
        }

        public static void WriteRecipe(IRecipe recipe)
        {
            string jsonText = JsonConvert.SerializeObject(recipe, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(_recipeFilePath, jsonText);
        }
    }
}

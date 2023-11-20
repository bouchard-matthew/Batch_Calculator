using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchCalculator.Models.Cookies
{
    internal class ChocolateChip
    {
        public static Dictionary<string, double> GetIngredients() =>
            new()
            {
                { "mainFlour", 3 },
                { "bakingSoda", 1 },
                { "salt", 1 },
                { "something", 3 }
            };
    }
}

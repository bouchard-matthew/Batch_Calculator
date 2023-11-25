using BatchCalculator.Interfaces;
using BatchCalculator.Models;
using Factory = BatchCalculator.Factory;

namespace Tests.Interfaces
{
    [TestClass]
    public class InterfaceTests
    {
        [TestMethod]
        public void GetDisplayName_ShouldReturnCorrectValue()
        {
            IIngredient ingredient = Factory.Factory.CreateIngredient("cheddarCheese", 1, BatchCalculator.Enums.Enums.Units.Cup);

            string displayName = ingredient.GetDisplayName();

            Assert.AreEqual("Cheddar Cheese", displayName);
        }

        [TestMethod]
        public void SetScale_ShouldModifyScale()
        {
            IIngredient ingredient = Factory.Factory.CreateIngredient("cheddarCheese", 1, BatchCalculator.Enums.Enums.Units.Cup);

            IIngredient scaledIngredient = ingredient.SetScale(2);

            Assert.AreEqual(2, scaledIngredient.GetScale());
        }

        [TestMethod]
        public void ToString_ShouldReturnNonEmptyString()
        {
            IIngredient ingredient = Factory.Factory.CreateIngredient("cheddarCheese", 1, BatchCalculator.Enums.Enums.Units.Cup);

            string result = ingredient.ToString();

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void FormatConvertedScaledIngredients_WithValidMeasurements_ReturnsExpectedOutput()
        {
            double[] measurements = { 1.5, 2.0, 3.0 };

            string result = Ingredient.FormatConvertedScaledIngredients(measurements);

            Assert.AreEqual("1.5 Cup + 2 Tbsp + 3 Tsp", result);
        }

        [TestMethod]
        public void FormatConvertedScaledIngredients_WithZeroMeasurements_ReturnsEmptyString()
        {
            double[] measurements = { 0.0, 0.0, 0.0 };

            string result = Ingredient.FormatConvertedScaledIngredients(measurements);

            Assert.AreEqual(string.Empty, result);
        }

    }
}

using Units = BatchCalculator.Enums.Enums.Units;

namespace Tests.Enums
{
    [TestClass]
    public class EnumTests
    {
        [TestMethod]
        public void EnumValues_AreExpected()
        {
            Assert.AreEqual(0, (int)Units.Tsp);
            Assert.AreEqual(1, (int)Units.Tbsp);
            Assert.AreEqual(2, (int)Units.Cup);
            Assert.AreEqual(3, (int)Units.Whole);
        }
    }
}

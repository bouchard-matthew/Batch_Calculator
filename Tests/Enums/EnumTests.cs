using static BatchCalculator.Enums.Enums;

namespace Tests.Enums
{
    [TestClass]
    public class EnumTests
    {
        [TestMethod]
        public void EnumValues_AreExpected()
        {
            Assert.AreEqual(0, (int)Unit.Tsp);
            Assert.AreEqual(1, (int)Unit.Tbsp);
            Assert.AreEqual(2, (int)Unit.Cup);
            Assert.AreEqual(3, (int)Unit.Whole);
        }
    }
}

using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class minusTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calcultor = new Minus();
            double actual = calcultor.Calculate(8, 2);
            Assert.AreEqual(6, actual);
        }
    }

}
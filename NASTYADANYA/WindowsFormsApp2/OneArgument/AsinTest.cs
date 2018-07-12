using NUnit.Framework;
using NASTYADANYA;

namespace NASTYADANYATest
{
    [TestFixture]
    public class AsinTests
    {
        [TestCase(1, 1.5708)]
        [TestCase(0, 0.0000)]
        [TestCase(-1, -1.5708)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Asin();
            double actualResult = calculator.Calculate(0);
            Assert.AreEqual(0.0000, actualResult, 0.0001);
        }
    }
}
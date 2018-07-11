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
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("Asin");
            double actualResult = calculator.Calculate(0.6521);
            Assert.AreEqual(0.7104, actualResult, 0.0001);
        }
    }
}
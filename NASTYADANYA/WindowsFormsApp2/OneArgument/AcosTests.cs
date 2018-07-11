using NUnit.Framework;
using NASTYADANYA;

namespace NASTYADANYATest
{
    [TestFixture]
    public class AcosTests
    {
        [TestCase(0, 1.5708)]
        [TestCase(1, 0.0000)]
        [TestCase(-1, 3.1416)]
        public void CalculateTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("Arcos");
            double actualResult = calculator.Calculate(0.6521);
            Assert.AreEqual(0.8604, actualResult, 0.0001);
        }
    }
}
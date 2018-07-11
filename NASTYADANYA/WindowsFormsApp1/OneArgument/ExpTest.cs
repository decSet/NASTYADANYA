using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(1, 2.7182)]
        [TestCase(2, 7.3890)]
        [TestCase(3, 20.085)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Exp();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class MaxTests
    {
        [TestCase(7, 1, 7)]
        [TestCase(5, 1, 5)]
        [TestCase(27, 3, 27)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Max();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
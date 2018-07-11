using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(7, 7, 1)]
        [TestCase(5, 1, 5)]
        [TestCase(27, 3, 9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
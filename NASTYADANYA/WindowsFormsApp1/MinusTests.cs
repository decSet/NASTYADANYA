using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class MinusTests
    {
        [TestCase(4, 7, -3)]
        [TestCase(5, 9, -4)]
        [TestCase(27, 51, -36)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Minus();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
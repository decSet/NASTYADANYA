using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(4, 7, 28)]
        [TestCase(5, 9, 45)]
        [TestCase(20, 5, 100)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
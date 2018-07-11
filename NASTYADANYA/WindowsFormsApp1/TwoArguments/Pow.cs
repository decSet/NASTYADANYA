using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class PowTests
    {
        [TestCase(7, 7, 49)]
        [TestCase(5, 1, 5)]
        [TestCase(3, 3, 9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Pow();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

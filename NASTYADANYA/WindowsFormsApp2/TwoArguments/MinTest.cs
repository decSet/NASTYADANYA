using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(7, 1, 1)]
        [TestCase(5, 1, 1)]
        [TestCase(27, 3, 3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Min();
            var actualResult = calculator.Calculate(7, 1);
            Assert.AreEqual(7, actualResult);
        }
    }
}
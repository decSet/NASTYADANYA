using NUnit.Framework;
using NASTYADANYA;

namespace NASTYADANYATest
{
    [TestFixture]
    public class AtgTests
    {
        [TestCase(1, 0.7854)]
        [TestCase(2, 1.1072)]
        [TestCase(3, 1.2491)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Atg();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
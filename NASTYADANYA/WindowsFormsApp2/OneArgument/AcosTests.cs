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
            var calculator = new Acos();
            double actualResult = calculator.Calculate(-1);
            Assert.AreEqual(3.1416, actualResult, 0.0001);
        }
    }
}
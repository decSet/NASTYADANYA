using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class LnXTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.3010)]
        [TestCase(3, 0.4771)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Log(); ;
            double actualResult = calculator.Calculate(4);
            Assert.AreEqual(1.3863, actualResult, 0.0001);
        }
    }
}
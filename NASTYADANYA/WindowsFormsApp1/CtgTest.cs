using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calcultor = new Ctg();
            double actual = calcultor.Calculate(0.785);
            Assert.AreEqual(1, actual);
        }
    }

}
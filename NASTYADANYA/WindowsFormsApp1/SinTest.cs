
using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class SinTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calcultor = new Sin();
            double actual = calcultor.Calculate(0);
            Assert.AreEqual(1, actual);
        }
    }

}
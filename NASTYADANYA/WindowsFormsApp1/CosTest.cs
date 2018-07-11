
using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calcultor = new Cos();
            double actual = calcultor.Calculate(0);
            Assert.AreEqual(1, actual);
        }
    }

}
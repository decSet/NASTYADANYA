using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class AbsTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calcultor = new Abs();
            double actual = calcultor.Calculate(0.785);
            Assert.AreEqual(1, actual);
        }
    }

}
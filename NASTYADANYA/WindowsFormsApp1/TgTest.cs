using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class TgTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calcultor = new Tg();
            double actual = calcultor.Calculate(1);
            Assert.AreEqual(1, 557, actual);
        }
    }

}
using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calcultor = new Division();
            double actual = calcultor.Calculate(8, 2);
            Assert.AreEqual(4, actual);
        }
    }

}
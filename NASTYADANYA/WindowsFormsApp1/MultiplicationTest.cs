using NASTYADANYA;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class MultiplicationTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calcultor = new Multiplication();
            double actual = calcultor.Calculate(8, 2);
            Assert.AreEqual(16, actual);
        }
    }

}
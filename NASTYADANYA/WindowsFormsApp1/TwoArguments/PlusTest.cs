﻿using NASTYADANYA;
using NUnit.Framework;

namespace NASTYADANYATest
{
    [TestFixture]
    public class PlusTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calcultor = new Plus();
            double actual = calcultor.Calculate(8, 2);
            Assert.AreEqual(10, actual);
        }
    }
}
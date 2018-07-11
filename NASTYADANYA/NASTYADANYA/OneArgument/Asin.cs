using System;

namespace NASTYADANYA
{
    public class Asin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}
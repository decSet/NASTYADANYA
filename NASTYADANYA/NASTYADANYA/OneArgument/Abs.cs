using System;

namespace NASTYADANYA
{
    public class Abs : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
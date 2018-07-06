using System;

namespace NASTYADANYA
{
    public class Sin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
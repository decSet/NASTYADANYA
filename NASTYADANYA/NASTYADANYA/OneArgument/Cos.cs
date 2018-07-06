using System;

namespace NASTYADANYA
{
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
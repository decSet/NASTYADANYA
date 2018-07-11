using System;

namespace NASTYADANYA
{
    public class Exp : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
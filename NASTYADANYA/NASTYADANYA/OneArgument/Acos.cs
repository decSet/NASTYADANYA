using System;

namespace NASTYADANYA
{
    public class Acos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}
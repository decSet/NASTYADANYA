using System;

namespace NASTYADANYA
{
    public class Log10 : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}
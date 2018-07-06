using System;

namespace NASTYADANYA
{
    public class Tg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
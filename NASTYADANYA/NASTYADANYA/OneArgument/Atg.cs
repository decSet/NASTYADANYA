using System;

namespace NASTYADANYA
{
    public class Atg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}.
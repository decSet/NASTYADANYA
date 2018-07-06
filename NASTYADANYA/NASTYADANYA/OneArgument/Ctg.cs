using System;

namespace NASTYADANYA
{
    public class Ctg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}

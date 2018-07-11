using System;

namespace NASTYADANYA
{
    public class Ctg : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate cos function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}

using System;

namespace NASTYADANYA
{
    public class Asin : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate Asim function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}
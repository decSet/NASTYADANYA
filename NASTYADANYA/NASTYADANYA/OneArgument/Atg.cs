using System;

namespace NASTYADANYA
{
    public class Atg : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate Atg function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
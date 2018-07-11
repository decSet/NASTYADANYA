using System;

namespace NASTYADANYA
{
    public class Sin : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate tg function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
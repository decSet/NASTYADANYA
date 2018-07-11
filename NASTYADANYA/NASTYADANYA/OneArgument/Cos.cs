using System;

namespace NASTYADANYA
{
    public class Cos : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate tg function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
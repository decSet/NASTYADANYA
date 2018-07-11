using System;

namespace NASTYADANYA
{
    public class Pow : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate addition function 
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <param name="secondArgument"> any number </param>
        /// <returns> any number </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
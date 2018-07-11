using System;

namespace NASTYADANYA
{
    public class Acos : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate Acos function
        /// </summary>
        /// /// <param name="firstArgument"> the number lying in the gap[-1;1] </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}
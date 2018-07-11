using System;

namespace NASTYADANYA
{
    public class IEEEremainder : ITwoArgumentsCalculator
    { 
    /// <summary>
    /// calculate division function
    /// </summary>
    /// <param name="firstArgument"> any number </param>
    /// <param name="secondArgument"> any number</param>
    /// <returns> any number </returns>
    public double Calculate(double firstArgument,double secondArgument)
        {
            return Math.IEEERemainder(firstArgument,secondArgument);
        }
    }
}
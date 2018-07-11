using System;

namespace NASTYADANYA
{
    public class IEEEremainder : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument,double secondArgument)
        {
            return Math.IEEERemainder(firstArgument,secondArgument);
        }
    }
}
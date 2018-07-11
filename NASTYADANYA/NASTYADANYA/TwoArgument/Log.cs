using System;

namespace NASTYADANYA
{
    public class Log : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}
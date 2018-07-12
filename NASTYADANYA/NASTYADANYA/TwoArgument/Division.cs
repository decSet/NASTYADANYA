using NASTYADANYA;
using System;


    public class Division : ITwoArgumentsCalculator

    {
    /// <summary>
    /// calculate addition function 
    /// </summary>
    /// <param name="firstArgument"> any number </param>
    /// <param name="secondArgument"> any number </param>
    /// <returns> any number </returns>
    public double Calculate(double firstArgument, double secondArgument)
        {
             if (secondArgument == 0)

              {
                throw new Exception("Error! Division by zero!");

              }

                return firstArgument / secondArgument;
        }
    }

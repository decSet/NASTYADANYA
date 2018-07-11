﻿using System;

namespace NASTYADANYA
{
    public class Log10 : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate of the decimal logarithm
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap (0;+infinity) </param>
        /// <returns> result any number </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}
﻿using System;

namespace NASTYADANYA
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Plus":
                    return new Plus();
                case "Minus":
                    return new Minus();
                case "Multiplication":
                    return new Multiplication();
                case "Division":
                    return new Division();
                default:
                    throw new Exception("error");
            }
        }
    }
}
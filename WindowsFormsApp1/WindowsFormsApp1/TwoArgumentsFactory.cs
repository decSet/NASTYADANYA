using System;

namespace NASTYADANYA
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "plus":
                    return new plus();
                case "minus":
                    return new minus();
                case "multiplication":
                    return new multiplication();
                case "division":
                    return new division();
                default:
                    throw new Exception("error");
            }
        }
    }
}
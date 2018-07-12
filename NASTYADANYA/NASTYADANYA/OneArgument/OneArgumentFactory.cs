using System;

namespace NASTYADANYA
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin": return new Sin();
                case "Cos": return new Cos();
                case "Tg": return new Tg();
                case "Ctg": return new Ctg();
                case "Sqrt": return new Sqrt();
                case "Abs": return new Abs();
                case "Exp": return new Exp();
                case "Acos": return new Acos();
                case "Asin": return new Asin();
                case "Atg": return new Atg();
                case "Log": return new Log();
                case "Log10": return new Log10();
                
                default:
                    throw new Exception("error");
            }
        }
    }
}
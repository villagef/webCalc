using CalculatorDll.Interfaces;
using System;

namespace CalculatorDll
{
    public class Addition : ICalc
    {
        public double MathOperation(double a, double b)
        {
            return a + b;
        }
    }
}

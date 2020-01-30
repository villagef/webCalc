using CalculatorDll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDll
{
    public class Substraction : ICalc
    {
        public double MathOperation(double a, double b)
        {
            return a - b;
        }
    }
}

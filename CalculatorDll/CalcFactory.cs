using CalculatorDll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDll
{
    public enum OperationType
    {
        Addition,
        Multiplication,
        Division,
        Subtraction,
        Unknown
    }

    public class CalcFactory
    {
        public ICalc GetOperation(OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Addition: return new Addition();
                case OperationType.Division: return new Division();
                case OperationType.Subtraction: return new Substraction();
                case OperationType.Multiplication: return new Multiplication();
            }

            throw new Exception("Unknown Operation");
        }
    }
}

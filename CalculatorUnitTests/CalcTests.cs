using CalculatorDll;
using NUnit.Framework;
using System;

namespace CalculatorUnitTests
{
    public class CalcTests
    {
        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(2, -2, ExpectedResult = 0)]
        [TestCase(-2, -2, ExpectedResult = -4)]
        public double AdditionTest(double a, double b)
        {
            var operation = new Addition();
            return operation.MathOperation(a, b);
        }

        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(2, -2, ExpectedResult = -4)]
        [TestCase(-2, -2, ExpectedResult = 4)]
        [TestCase(0, 100, ExpectedResult = 0)]
        public double MultiplicationTest(double a, double b)
        {
            var operation = new Multiplication();
            return operation.MathOperation(a, b);
        }

        [TestCase(2, 2, ExpectedResult = 1)]
        [TestCase(2, -2, ExpectedResult = -1)]
        [TestCase(-2, -2, ExpectedResult = 1)]
        public double DivisionTest(double a, double b)
        {
            var operation = new Division();
            return operation.MathOperation(a, b);
        }

        [TestCase(2, 0)]
        public void DivisionNegativeTest(double a, double b)
        {
            var operation = new Division();
            //// in C# divide by 0 with double type is infinity 
            Assert.AreEqual(operation.MathOperation(a, b), Double.PositiveInfinity);
        }

        [TestCase(OperationType.Addition, ExpectedResult = typeof(Addition))]
        [TestCase(OperationType.Division, ExpectedResult = typeof(Division))]
        [TestCase(OperationType.Subtraction, ExpectedResult = typeof(Substraction))]
        [TestCase(OperationType.Multiplication, ExpectedResult = typeof(Multiplication))]
        public Type CalcFactoryTest(OperationType operation)
        {
            var factory = new CalcFactory();
            return factory.GetOperation(operation).GetType();
        }

        [TestCase(2, 2, ExpectedResult = 0)]
        [TestCase(2, -2, ExpectedResult = 4)]
        [TestCase(-2, -2, ExpectedResult = 0)]
        public double SubtractionTest(double a, double b)
        {
            var operation = new Substraction();
            return operation.MathOperation(a, b);
        }
    }
}
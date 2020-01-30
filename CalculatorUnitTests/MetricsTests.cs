using CalculatorDll;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitTests
{
    public class MetricsTests
    {
        [TestCase(4.26, ExpectedResult = 2.65)]
        public double KmToMiles(double km)
        {
            var distance = new MetricsDistance();
            return Math.Round(distance.ConvertKilometersToMiles(km), 2);
        }

        [TestCase(2.65, ExpectedResult = 4.26)]
        public double MilesToKm(double miles)
        {
            var distance = new MetricsDistance();
            return Math.Round(distance.ConvertMilesToKilometers(miles),2);
        }

        [TestCase(10, ExpectedResult = 50)]
        public int CelciusToFahrenheitTest(double c)
        {
            var temperature = new MetricsTemperature();
            return temperature.ConvertCelsiusToFahrenheit(c);
        }

        [TestCase(50, ExpectedResult = 10)]
        public int FahrenheitToCelciusTest(double f)
        {
            var temperature = new MetricsTemperature();
            return temperature.ConvertFahrenheitToCelsius(f);
        }

        [TestCase(54, ExpectedResult = 21.26)]
        public double CmToInchesTest(double cm)
        {
            var length = new MetricsLength();
            return Math.Round(length.ConvertCmToInches(cm), 2);
        }

        [TestCase(21.26, ExpectedResult = 54)]
        public double InchesToCmTest(double inc)
        {
            var length = new MetricsLength();
            return Math.Round(length.ConvertInchesToCm(inc), 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDll
{
    public class MetricsTemperature
    {
        public int ConvertCelsiusToFahrenheit(double c)
        {
            return Convert.ToInt32(((9.0 / 5.0) * c) + 32);
        }

        public int ConvertFahrenheitToCelsius(double f)
        {
            return Convert.ToInt32((5.0 / 9.0) * (f - 32));
        }
    }
}

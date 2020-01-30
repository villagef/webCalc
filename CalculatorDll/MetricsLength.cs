using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDll
{
    public class MetricsLength
    {
        public double ConvertCmToInches(double cm)
        {
            return 0.3937 * cm;
        }

        public double ConvertInchesToCm(double inc)
        {
            return inc * 2.54;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webCalc.Models
{
    public class Distance
    {
        public double? Miles { get; set; }

        public double? Km { get; set; }
    }

    public class Length
    {
        public double? Cm { get; set; }

        public double? Inches { get; set; }
    }

    public class Temperature
    {
        public double? Celcius { get; set; }

        public double? Fahrenheit { get; set; }
    }

    public class Metric
    {
        public Metric()
        {
            //Distance = new Distance();
            //Length = new Length();
            //Temperature = new Temperature();
        }

        public double? Cm { get; set; }

        public double? Inches { get; set; }

        public Distance Distance { get; set; }

        public Length Length { get; set; }

        public Temperature Temperature { get; set; }
    }
}

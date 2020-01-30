namespace CalculatorDll
{
    public class MetricsDistance
    {
        public double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.609344;
        }

        public double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371192;
        }
    }
}

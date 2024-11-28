namespace coding_practice_dotnet.MetricConversion
{
    internal class MetricConverter
    {
        private readonly Dictionary<string, Dictionary<string, double>> conversionFactors = [];

        public double Convert(string source, string destination, double value)
        {
            return !conversionFactors.ContainsKey(source) || !conversionFactors[source].ContainsKey(destination)
                ? throw new Exception("Conversion not supported")
                : value * conversionFactors[source][destination];
        }

        public void AddConversion(string fromUnit, string toUnit, double multiplier)
        {
            if (!conversionFactors.ContainsKey(fromUnit))
            {
                conversionFactors[fromUnit] = [];
            }

            conversionFactors[fromUnit][toUnit] = multiplier;

            // Add reverse as well
            if (!conversionFactors.ContainsKey(toUnit))
            {
                conversionFactors[toUnit] = [];
            }
            conversionFactors[toUnit][fromUnit] = 1 / multiplier;
        }
    }
}

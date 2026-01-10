namespace ConverterApp.Converters
{
    public class TemperatureConverter : BaseConverter
    {
        public override string ConverterType => "Температура";

        public override string[] GetUnits()
        {
            return new string[] { "C", "F", "K" };
        }

        public override double Convert(double value, string fromUnit, string toUnit)
        {
            double celsius = ToCelsius(value, fromUnit);

            return FromCelsius(celsius, toUnit);
        }

        private double ToCelsius(double value, string fromUnit)
        {
            if (fromUnit == "C") return value;
            if (fromUnit == "F") return (value - 32) * 5 / 9;
            if (fromUnit == "K") return value - 273.15;
            throw new ArgumentException("Неизвестная единица: " + fromUnit);
        }

        private double FromCelsius(double celsius, string toUnit)
        {
            if (toUnit == "C") return celsius;
            if (toUnit == "F") return (celsius * 9 / 5) + 32;
            if (toUnit == "K") return celsius + 273.15;
            throw new ArgumentException("Неизвестная единица: " + toUnit);
        }
    }
}
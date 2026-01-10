namespace ConverterApp.Converters
{
    public abstract class BaseConverter
    {
        public abstract string ConverterType { get; }
        public abstract string[] GetUnits();
        public abstract double Convert(double value, string fromUnit, string toUnit);

        public bool CanConvert(string fromUnit, string toUnit)
        {
            var units = GetUnits();
            return units.Contains(fromUnit) && units.Contains(toUnit);
        }
    }
}
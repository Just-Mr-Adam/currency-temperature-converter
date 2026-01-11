
using System;
using System.Net.Http;
using System.Text.Json;

namespace ConverterApp.Converters
{
    public class CurrencyConverter : BaseConverter
    {
        public override string ConverterType => "Валюты";

        public override string[] GetUnits()
        {
            return new string[] { "RUB", "USD", "EUR", "GBP", "JPY" };
        }

        public override double Convert(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == toUnit) return value;

            try
            {
                // Простой тест без API
                if (fromUnit == "USD" && toUnit == "EUR") return value * 0.92;
                if (fromUnit == "EUR" && toUnit == "USD") return value * 1.09;
                if (fromUnit == "USD" && toUnit == "RUB") return value * 90.5;
                if (fromUnit == "RUB" && toUnit == "USD") return value / 90.5;

                return value; // заглушка
            }
            catch
            {
                throw new Exception("Ошибка конвертации");
            }
        }
    }
}
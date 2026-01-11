using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;

namespace ConverterApp.Converters
{
    public class CurrencyConverter : BaseConverter
    {
        public override string ConverterType => "Валюты";

        public override string[] GetUnits()
        {
            try
            {
                string url = "https://www.cbr-xml-daily.ru/daily_json.js";

                HttpClient client = new HttpClient();
                string response = client.GetStringAsync(url).Result;

                JsonDocument json = JsonDocument.Parse(response);
                JsonElement valute = json.RootElement.GetProperty("Valute");

                List<string> currencies = new List<string> { "RUB" };

                foreach (JsonProperty currency in valute.EnumerateObject())
                {
                    currencies.Add(currency.Name);
                }

                return currencies.ToArray();
            }
            catch
            {
                // Если API не доступен - основные валюты
                return new string[]
                {
                    "RUB", "USD", "EUR", "AUD", "AZN",
                    "GBP", "JPY", "CNY", "CHF", "CAD"
                };
            }
        }

        public override double Convert(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == toUnit) return value;

            try
            {
                string url = "https://www.cbr-xml-daily.ru/daily_json.js";

                HttpClient client = new HttpClient();
                string responce = client.GetStringAsync(url).Result;

                JsonDocument json = JsonDocument.Parse(responce);
                JsonElement valute = json.RootElement.GetProperty("Valute");

                double fromRate, toRate;

                if (fromUnit == "RUB")
                {
                    fromRate = 1.0;
                }
                else
                {
                    JsonElement fromCurrency = valute.GetProperty(fromUnit);
                    fromRate = fromCurrency.GetProperty("Value").GetDouble();
                }

                if (toUnit == "RUB")
                {
                    toRate = 1.0;
                }
                else
                {
                    JsonElement toCurrency = valute.GetProperty(toUnit);
                    toRate = toCurrency.GetProperty("Value").GetDouble();
                }

                double result = (value * fromRate) / toRate;
                return Math.Round(result, 2);
            }
            catch (Exception ex)
            {
                // Если API не доступен - выбрасываем исключение
                throw new InvalidOperationException(
                    $"Не удалось получить курс валют. Проверьте интернет.\n" +
                    $"Детали: {ex.Message}");
            }
        }
    }
}
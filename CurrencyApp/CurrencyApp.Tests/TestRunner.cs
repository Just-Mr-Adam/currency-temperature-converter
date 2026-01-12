using ConverterApp.Converters;
using System;

namespace CurrencyApp.Tests;

public static class TestRunner
{
    public static int Execute()
    {
        int testsPassed = 0;
        int testsFailed = 0;

        TemperatureConverter converter = new TemperatureConverter();

        // Тест 1: Celsius → Fahrenheit
        try
        {
            double result = converter.Convert(100, "C", "F");
            if (Math.Abs(result - 212) < 0.01)
            {
                testsPassed++;
            }
            else
            {
                testsFailed++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"FAIL: Celsius to Fahrenheit - {ex.Message}");
            testsFailed++;
        }

        // Тест 2: Fahrenheit → Celsius
        try
        {
            double result = converter.Convert(32, "F", "C");
            if (Math.Abs(result - 0) < 0.01)
            {
                testsPassed++;
            }
            else
            {
                testsFailed++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"FAIL: Fahrenheit to Celsius - {ex.Message}");
            testsFailed++;
        }

        // Тест 3: Celsius → Kelvin
        try
        {
            double result = converter.Convert(0, "C", "K");
            if (Math.Abs(result - 273.15) < 0.01)
            {
                testsPassed++;
            }
            else
            {
                testsFailed++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"FAIL: Celsius to Kelvin - {ex.Message}");
            testsFailed++;
        }

        // Тест 4: Same unit conversion (edge case)
        try
        {
            double result = converter.Convert(50, "C", "C");
            if (Math.Abs(result - 50) < 0.01)
            {
                testsPassed++;
            }
            else
            {
                testsFailed++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"FAIL: Same unit conversion - {ex.Message}");
            testsFailed++;
        }

        // Тест 5: Invalid unit
        try
        {
            double result = converter.Convert(100, "C", "XYZ");
            testsFailed++;
        }
        catch (ArgumentException)
        {
            testsPassed++;
        }
        catch (Exception ex)
        {
            testsFailed++;
        }

        return testsFailed == 0 ? 0 : 1;
    }
}
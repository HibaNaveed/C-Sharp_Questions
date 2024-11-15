using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Currency Converter");
        Console.WriteLine("Available currencies: USD, EUR, GBP");

        Console.Write("Enter the currency you want to convert from (USD/EUR/GBP): ");
        string fromCurrency = Console.ReadLine().ToUpper();

        Console.Write("Enter the currency you want to convert to (USD/EUR/GBP): ");
        string toCurrency = Console.ReadLine().ToUpper();

        Console.Write("Enter the amount to convert: ");
        decimal amount = decimal.Parse(Console.ReadLine()); // Assumes valid numeric input

        decimal conversionRate = 0m;

        switch (fromCurrency + "-" + toCurrency)
        {
            case "USD-EUR": conversionRate = 0.85m; break;
            case "USD-GBP": conversionRate = 0.75m; break;
            case "EUR-USD": conversionRate = 1.18m; break;
            case "EUR-GBP": conversionRate = 0.88m; break;
            case "GBP-USD": conversionRate = 1.33m; break;
            case "GBP-EUR": conversionRate = 1.14m; break;
            case "USD-USD":
            case "EUR-EUR":
            case "GBP-GBP":
                conversionRate = 1m; break;
            default:
                Console.WriteLine("Invalid currency combination.");
                return;
        }

        decimal convertedAmount = amount * conversionRate;
        Console.WriteLine($"{amount} {fromCurrency} = {convertedAmount:F2} {toCurrency}");
    }
}
using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("Options: ");
        Console.WriteLine("1: Celsius to Fahrenheit");
        Console.WriteLine("2: Celsius to Kelvin");
        Console.WriteLine("3: Fahrenheit to Celsius");
        Console.WriteLine("4: Fahrenheit to Kelvin");
        Console.WriteLine("5: Kelvin to Celsius");
        Console.WriteLine("6: Kelvin to Fahrenheit");

        Console.Write("Select an option (1-6): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the temperature to convert: ");
        double inputTemperature = double.Parse(Console.ReadLine());

        double convertedTemperature;

        switch (choice)
        {
            case 1:
                convertedTemperature = (inputTemperature * 9 / 5) + 32;
                Console.WriteLine($"{inputTemperature}°C = {convertedTemperature:F2}°F");
                break;

            case 2: 
                convertedTemperature = inputTemperature + 273.15;
                Console.WriteLine($"{inputTemperature}°C = {convertedTemperature:F2}K");
                break;

            case 3:
                convertedTemperature = (inputTemperature - 32) * 5 / 9;
                Console.WriteLine($"{inputTemperature}°F = {convertedTemperature:F2}°C");
                break;

            case 4: 
                convertedTemperature = (inputTemperature - 32) * 5 / 9 + 273.15;
                Console.WriteLine($"{inputTemperature}°F = {convertedTemperature:F2}K");
                break;

            case 5: 
                convertedTemperature = inputTemperature - 273.15;
                Console.WriteLine($"{inputTemperature}K = {convertedTemperature:F2}°C");
                break;

            case 6: 
                convertedTemperature = (inputTemperature - 273.15) * 9 / 5 + 32;
                Console.WriteLine($"{inputTemperature}K = {convertedTemperature:F2}°F");
                break;

            default:
                Console.WriteLine("Invalid option. Please select a valid choice (1-6).");
                break;
        }
    }
}
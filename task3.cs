/*
Задание 3: перевод температуры
Формула: °F = °C × 9/5 + 32
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius = 25.0;

        // Convert to Fahrenheit
        double fahrenheit = celsius * 9.0 / 5.0 + 32;

        Console.WriteLine($"Temperature: {fahrenheit} °F");
    }
}

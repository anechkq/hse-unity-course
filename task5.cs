/*
Задание 5: преобразование типов
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double value = 7.85;

        // Explicit conversion to int
        int integerValue = (int)value;

        // Implicit conversion back to double
        double convertedValue = integerValue;

        // Compare values
        bool areEqual = value == convertedValue;

        Console.WriteLine($"Original value: {value}");
        Console.WriteLine($"Integer value: {integerValue}");
        Console.WriteLine($"Converted value: {convertedValue}");
        Console.WriteLine($"Values are equal: {areEqual}");
    }
}

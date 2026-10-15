/*
Задание 3: преобразование типов

Дана переменная:

double value = 3.99;

Нужно:
1. Преобразовать `value` в `int` и вывести результат
2. Преобразовать `int` обратно в `double` и вывести результат
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double value = 3.99;

        int wholeNumber = (int)value;
        Console.WriteLine($"Int: {wholeNumber}");

        double convertedValue = wholeNumber;
        Console.WriteLine($"Double: {convertedValue}");
    }
}

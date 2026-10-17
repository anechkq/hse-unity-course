/*
Задание 6: разбор строки с координатами
Вывод:

Coordinate x = 10
Coordinate y = 20
Coordinate z = 30

Подсказка: Split(';') → массив строк.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string data = "x=10;y=20;z=30";

        // Split and print each coordinate
        string[] coordinates = data.Split(';');

        string[] xData = coordinates[0].Split('=');
        string[] yData = coordinates[1].Split('=');
        string[] zData = coordinates[2].Split('=');

        Console.WriteLine($"Coordinate {xData[0]} = {xData[1]}");
        Console.WriteLine($"Coordinate {yData[0]} = {yData[1]}");
        Console.WriteLine($"Coordinate {zData[0]} = {zData[1]}");
    }
}

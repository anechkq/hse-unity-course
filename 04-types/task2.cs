/*
Задание 2: переменные для 3D-объекта

Нужно создать переменные: имя, координаты, масштаб, вращение, видимость.
Присвоить значения и вывести в консоль.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create variables here
        string objectName = "Cube";

        float x = 1.5f;
        float y = 2.0f;
        float z = -3.0f;

        float scale = 1.2f;
        float rotation = 45.0f;

        bool isVisible = true;

        Console.WriteLine($"Name: {objectName}");
        Console.WriteLine($"Coordinates: ({x}, {y}, {z})");
        Console.WriteLine($"Scale: {scale}");
        Console.WriteLine($"Rotation: {rotation}");
        Console.WriteLine($"Visible: {isVisible}");
    }
}

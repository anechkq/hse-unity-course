/*
Задание 4: информация о 3D-модели
Переменные: имя (string), полигоны (int), длительность анимации (float),
видимость (bool), угол поворота (float).
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create variables here
        var modelName = "Robot";
        int polygonCount = 12500;
        float animationDuration = 3.5f;
        bool isVisible = true;
        float rotationAngle = 45.0f;

        Console.WriteLine($"Model: {modelName}");
        Console.WriteLine($"Polygons: {polygonCount}");
        Console.WriteLine($"Animation duration: {animationDuration} seconds");
        Console.WriteLine($"Visible: {isVisible}");
        Console.WriteLine($"Rotation angle: {rotationAngle} degrees");
    }
}

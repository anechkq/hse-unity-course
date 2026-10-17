/*
Задание 7: обработка имени файла

Шаги: IndexOf('.') → Substring() → ToUpper()
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "level_01_scene.unity";

        // Find dot, extract name, convert to upper
        int dotIndex = fileName.IndexOf('.');
        string nameWithoutExtension = fileName.Substring(0, dotIndex);
        string upperName = nameWithoutExtension.ToUpper();

        Console.WriteLine($"File name: {upperName}");
    }
}

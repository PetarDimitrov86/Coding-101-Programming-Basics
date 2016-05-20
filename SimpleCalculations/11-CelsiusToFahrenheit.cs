using System;
class CelsiusToFahrenheit
{
    static void Main()
    {
        Console.Write("Celsius = ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = Math.Round(((celsius * 1.8) + 32), 3);
        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }
}
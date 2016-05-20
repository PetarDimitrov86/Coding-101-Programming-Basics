using System;
class MetricConverterUsingSwitchCase
{
    static void Main(string[] args)
    {
        double ammount = double.Parse(Console.ReadLine());
        string inputDistance = Console.ReadLine();
        string outputDistance = Console.ReadLine();
        double coefficient1 = 0.0;
        double coefficient2 = 0.0;
        switch (inputDistance)
        {
            case "m": coefficient1 = 1; break;
            case "mm": coefficient1 = 1000; break;
            case "cm": coefficient1 = 100; break;
            case "mi": coefficient1 = 0.000621371192; break;
            case "in": coefficient1 = 39.3700787; break;
            case "km": coefficient1 = 0.001; break;
            case "ft": coefficient1 = 3.2808399; break;
            case "yd": coefficient1 = 1.0936133; break;
        }
        switch (outputDistance)
        {
            case "m": coefficient2 = 1; break;
            case "mm": coefficient2 = 1000; break;
            case "cm": coefficient2 = 100; break;
            case "mi": coefficient2 = 0.000621371192; break;
            case "in": coefficient2 = 39.3700787; break;
            case "km": coefficient2 = 0.001; break;
            case "ft": coefficient2 = 3.2808399; break;
            case "yd": coefficient2 = 1.0936133; break;
        }
        Console.WriteLine("{0} {1}", ammount * (coefficient2 / coefficient1), outputDistance);
    }
}
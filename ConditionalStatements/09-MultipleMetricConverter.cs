using System;
using System.Collections.Generic;
class MultipleMetricConverter
{
    static void Main(string[] args)
    {
        double ammount = double.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();
        var coefficient = new Dictionary<string, double>()
        {
            {"m",1 },
            {"mm",1000d },
            {"cm",100d },
            {"mi",0.000621371192d },
            {"in",39.3700787d },
            {"km",0.001d },
            {"ft",3.2808399d },
            {"yd",1.0936133d },
        };
        double result = ammount * (coefficient[outputCurrency] / coefficient[inputCurrency]);
        Console.WriteLine(result + " " + outputCurrency);
    }
}
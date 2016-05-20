using System;
using System.Collections.Generic;
class MultipleCurrenciesConvVer3
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string firstCurrency = Console.ReadLine();
        string secondCurrency = Console.ReadLine();
        var currencies = new Dictionary<string, decimal>()
        {
            {"BGN",1 },
            {"USD",1.79549m },
            {"EUR",1.95583m },
            {"GBP",2.53405m },
        };
        decimal result = cash * (currencies[firstCurrency] / currencies[secondCurrency]);
        Console.WriteLine(Math.Round(result, 2));
    }
}
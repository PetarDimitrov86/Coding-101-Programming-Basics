using System;
using System.Collections.Generic;
class FruitShop
{
    public static void Main()
    {
        var weekdays = new List<string>(new string[] { "monday", "tuesday", "wednesday", "thursday", "friday" });
        var weekends = new List<string>(new string[] { "saturday", "sunday" });

        var fruitsPrices = new Dictionary<string, decimal[]>
        {
            {"banana", new decimal[] { 2.5m, 2.7m }},
            {"apple", new decimal[] { 1.2m, 1.25m }},
            {"orange",new decimal[] { 0.85m, 0.9m }},
            {"grapefruit", new decimal[] { 1.45m, 1.6m }},
            {"kiwi", new decimal[] { 2.7m, 3m }},
            {"pineapple", new decimal[] { 5.5m, 5.6m }},
            {"grapes", new decimal[] { 3.85m, 4.2m }}
        };
        try
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());

            if (weekdays.Contains(day))
            {
                decimal price = quantity * fruitsPrices[fruit][0];
                Console.WriteLine(String.Format("{0:0.00}", price));
            }
            else if (weekends.Contains(day))
            {
                decimal price = quantity * fruitsPrices[fruit][1];
                Console.WriteLine(String.Format("{0:0.00}", price));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("error");
        }
    }
}
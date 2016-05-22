using System;
class Program
{
    static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string destination = string.Empty;
        decimal moneySpent = 0;
        string campType = string.Empty;
        if (season == "summer")
            campType = "Camp";
        else
            campType = "Hotel";

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
                moneySpent = 0.3m * budget;
            else if (season == "winter")
                moneySpent = 0.7m * budget;
        }
        else if (budget > 100 && budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
                moneySpent = 0.4m * budget;
            else if (season == "winter")
                moneySpent = 0.8m * budget;
        }
        else
        {
            destination = "Europe";
            moneySpent = 0.9m * budget;
            campType = "Hotel";
        }
        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{campType} - {moneySpent:f2}");
    }
}

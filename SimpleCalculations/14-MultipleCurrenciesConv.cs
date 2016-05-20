using System;
class MultipleCurrenciesConv
{
    static void Main()
    {
        Console.Write("Enter amount to convert = ");
        double cash = double.Parse(Console.ReadLine());
        Console.Write("Enter the input currency (BGN, USD, EUR or GBP) = ");
        string input = (Console.ReadLine());
        Console.Write("Enter the desired output currency (BGN, USD, EUR or GBP) = ");
        string output = (Console.ReadLine());
        double USDtoBGN = (cash * 1.79549);
        double EURtoBGN = (cash * 1.95583);
        double GBPtoBGN = (cash * 2.53405);
        if (input == "USD")
            if (output == "BGN")
                Console.WriteLine(Math.Round(USDtoBGN, 2));
        if (input == "EUR")
            if (output == "BGN")
                Console.WriteLine(Math.Round(EURtoBGN, 2));
        if (input == "GBP")
            if (output == "BGN")
                Console.WriteLine(Math.Round(GBPtoBGN, 2));
        if (input == "USD")
            if (output == "EUR")
                Console.WriteLine(Math.Round((USDtoBGN / 1.95583), 2));
        if (input == "BGN")
            if (output == "EUR")
                Console.WriteLine(Math.Round((cash / 1.95583), 2));
        if (input == "GBP")
            if (output == "EUR")
                Console.WriteLine(Math.Round((GBPtoBGN / 1.95583), 2));
        if (input == "EUR")
            if (output == "USD")
                Console.WriteLine(Math.Round((EURtoBGN / 1.79549), 2));
        if (input == "BGN")
            if (output == "USD")
                Console.WriteLine(Math.Round((cash / 1.79549), 2));
        if (input == "GBP")
            if (output == "USD")
                Console.WriteLine(Math.Round((GBPtoBGN / 1.79549), 2));
        if (input == "EUR")
            if (output == "GBP")
                Console.WriteLine(Math.Round((EURtoBGN / 2.53405), 2));
        if (input == "BGN")
            if (output == "GBP")
                Console.WriteLine(Math.Round((cash / 2.53405), 2));
        if (input == "USD")
            if (output == "GBP")
                Console.WriteLine(Math.Round((USDtoBGN / 2.53405), 2));
    }
}
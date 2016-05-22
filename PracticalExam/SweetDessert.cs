using System;
class SweetDessert
{
    static void Main(string[] args)
    {
        decimal ivanchoCash = decimal.Parse(Console.ReadLine());
        long guests = long.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggPrice = decimal.Parse(Console.ReadLine());
        decimal berriePricePerKG = decimal.Parse(Console.ReadLine());

        long portionsNeeded = ((guests + 5) / 6);
        decimal totalCost = portionsNeeded * (2 * bananaPrice + 4 * eggPrice + 0.2m * berriePricePerKG);

        if (totalCost <= ivanchoCash)
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalCost);
        else
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", totalCost - ivanchoCash);
    }
}
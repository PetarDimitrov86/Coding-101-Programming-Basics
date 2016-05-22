using System;
class Program
{
    static void Main(string[] args)
    {
        decimal priceVegetables = decimal.Parse(Console.ReadLine());
        decimal priceFruit = decimal.Parse(Console.ReadLine());
        int kgVeg = int.Parse(Console.ReadLine());
        int kgFru = int.Parse(Console.ReadLine());

        decimal totalProfit = priceVegetables * kgVeg+ priceFruit * kgFru;

        Console.WriteLine("{0}", totalProfit / 1.94m);
    }
}

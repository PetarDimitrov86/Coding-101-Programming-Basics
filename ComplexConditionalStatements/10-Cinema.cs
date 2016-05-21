using System;
class Cinema
{
    static void Main(string[] args)
    {
        string priceCategory = Console.ReadLine().ToLower();
        int columns = int.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        if (priceCategory == "premiere")
            Console.WriteLine("{0:f2} leva", columns * rows * 12);
        else if (priceCategory == "normal")
            Console.WriteLine("{0:f2} leva", columns * rows * 7.50);
        else if (priceCategory == "discount")
            Console.WriteLine("{0:f2} leva", columns * rows * 5);
    }
}
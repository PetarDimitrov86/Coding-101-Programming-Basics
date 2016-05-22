using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string tariffe = Console.ReadLine();
        double finalPrice = 0;

        if (tariffe == "day")
        {
            if (n < 20)
            {
                finalPrice = n * 0.79 + 0.70;
            }
            else if (n < 100)
                finalPrice = 0.09 * n;
            else 
                finalPrice =  0.06 * n;
        }
        if (tariffe == "night")
        {
            if (n < 20)
            {
                finalPrice = n * 0.90 + 0.70;
            }
            else if (n < 100)
                finalPrice = 0.09 * n;
            else if (n <= 5000)
                finalPrice = 0.06 * n;
        }
        Console.WriteLine(finalPrice);
    }
}

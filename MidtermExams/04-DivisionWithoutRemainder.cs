using System;
class Program
{
    static void Main(string[] args)
    {
        int totalNumbers = int.Parse(Console.ReadLine());
        decimal p1 = 0;
        decimal p2 = 0;
        decimal p3 = 0;
        for (int i = 0; i < totalNumbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                p1++;
            if (number % 3 == 0)
                p2++;
            if (number % 4 == 0)
                p3++;
        }
        Console.WriteLine("{0:f2}%", (p1 * 100m) / totalNumbers);
        Console.WriteLine("{0:f2}%", (p2 * 100m) / totalNumbers);
        Console.WriteLine("{0:f2}%", (p3 * 100m) / totalNumbers);
    }
}

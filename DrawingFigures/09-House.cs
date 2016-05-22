using System;
class House
{
static void Main(string[] args)
{
    int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        for (int row = 1; row <= n / 2; row++)
        {
            Console.Write(new string('-', (n / 2 - row)));
            Console.Write(new string('*', 2 * row));
            Console.Write(new string('-', (n / 2 - row)));
            Console.WriteLine();
        }
    }
    else
    {
        for (int row = 1; row <= n / 2 +1; row++)
        {
            Console.Write(new string('-', (n / 2 - row+1)));
            Console.Write(new string('*', 2 * row - 1));
            Console.Write(new string('-', (n / 2 - row+1)));
            Console.WriteLine();
        }
    }
    for (int row = 1; row <= n/2; row++)
    {
        Console.Write("|");
        Console.Write(new string('*', n-2));
        Console.WriteLine("|");
    }
}
}

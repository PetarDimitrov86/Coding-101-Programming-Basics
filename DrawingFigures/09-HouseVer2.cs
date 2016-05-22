using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var stars = 1;
        if (n % 2 == 0)
        {
            stars = 2;
        }

        for (int row = 0; row < (n + 1) / 2; row++)
        {
            var hyphens = (n - stars) / 2;
            Console.Write(new string('-', hyphens));
            Console.Write(new string('*', stars));
            Console.Write(new string('-', hyphens));
            Console.WriteLine();
            stars = stars + 2;
        }
        for (int row = 1; row <= n / 2; row++)
        {
            Console.Write("|");
            Console.Write(new string('*', n - 2));
            Console.WriteLine("|");
        }
    }
}

using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int mid = 0;
        if (n > 4)
            mid = n * 2 - 2;
        Console.Write("/");
        Console.Write(new string('^', n/2));
        Console.Write("\\");
        if (n>4)
        {
            Console.Write(new string('_', 2 * n - (n / 2) - (n / 2) - 4));
        }
        Console.Write("/");
        Console.Write(new string('^', n / 2));
        Console.WriteLine("\\");

        for (int row = 1; row <= n - 3; row++)
        {
            Console.Write("|");
            Console.Write(new string(' ', 2*n - 2));
            Console.WriteLine("|");
        }


        Console.Write("|");
        Console.Write(new string(' ', n/2 + 1));
        if (n>4)
        {
            Console.Write(new string('_', 2 * n - (n / 2) - (n / 2) - 4));
        }       
        Console.Write(new string(' ', n / 2 + 1));
        Console.WriteLine("|");

        Console.Write("\\");
        Console.Write(new string('_', n / 2));
        Console.Write("/");
        if (n > 4)
        {
            Console.Write(new string(' ', 2 * n - (n / 2) - (n / 2) - 4));
        }
        Console.Write("\\");
        Console.Write(new string('_', n / 2));
        Console.WriteLine("/");

    }
}

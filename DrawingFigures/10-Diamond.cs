using System;
class Diamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("*");
        }
        else if (n % 2 == 0)
        {
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('-', n / 2 - row));
                Console.Write("*");
                Console.Write(new string('-', row * 2 - 2));
                Console.Write("*");
                Console.Write(new string('-', n / 2 - row));
                Console.WriteLine();
            }
            for (int row = 1; row < n / 2; row++)
            {
                Console.Write(new string('-', row));
                Console.Write("*");
                Console.Write(new string('-', n - 2 * row - 2));
                Console.Write("*");
                Console.Write(new string('-', row));
                Console.WriteLine();
            }
        }
        else
        {
            Console.Write(new string('-', n / 2));
            Console.Write("*");
            Console.WriteLine(new string('-', n / 2));
            for (int row = 1; row <= n/2; row++)
            {
                Console.Write(new string('-', n/2 - row));
                Console.Write("*");
                Console.Write(new string('-', row*2 - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', n / 2 - row));
            }
            for (int row = 1; row <= n / 2 - 1; row++)
            {
                Console.Write(new string('-', row));
                Console.Write("*");
                Console.Write(new string('-', n - 2*row - 2));
                Console.Write("*");
                Console.WriteLine(new string('-', row));
            }
            Console.Write(new string('-', n / 2));
            Console.Write("*");
            Console.Write(new string('-', n / 2));
        }
    }
}

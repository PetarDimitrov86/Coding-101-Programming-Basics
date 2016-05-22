using System;
class Sunglasses
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));
        for (int row = 0; row < n-2 ; row++)
        {
            Console.Write("*");
            Console.Write(new string('/', 2*n - 2));
            Console.Write("*");
            if (Math.Ceiling(n / 2.0) == row + 2 )
            {
                Console.Write(new string('|', n));
            }
            else
                Console.Write(new string(' ', n));
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.WriteLine("*");
        }
        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));
    }
}

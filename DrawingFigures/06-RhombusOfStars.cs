using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            Console.Write(new string(' ', n - row - 1));
            for (int col = 0; col < row; col++)
            {
                Console.Write("* ");
            }
            Console.Write("*");
            Console.WriteLine();
        }
        for (int row = 0; row < n - 1; row++)
        {
            Console.Write(new string(' ', row + 1));
            for (int col = n - 2; col > row; col--)
            {
                Console.Write("* ");
            }
            Console.Write("*");
            Console.WriteLine();
        }
    }

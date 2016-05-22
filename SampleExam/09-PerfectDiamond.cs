using System;
class PerfectDiamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            for (int col = 1; col <= row - 1; col++)
            {
                Console.Write("*-");
            }
            Console.WriteLine("*");
        }

        for (int row = 1; row <= n-1; row++)
        {
            Console.Write(new string(' ', row));
            for (int col = n-1; col > row; col--)
            {
                Console.Write("*-");
            }
            Console.WriteLine("*");
        }
    }
}

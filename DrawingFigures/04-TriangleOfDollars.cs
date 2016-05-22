using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            if (row == 1)
                Console.Write("$");
            else
            {
            for (int col = 1; col <= row; col++)
            {
                    if (col == 1)
                        Console.Write("$");
                    else
                        Console.Write(" $");
            }
            }
        Console.WriteLine();
        }
    }
  }

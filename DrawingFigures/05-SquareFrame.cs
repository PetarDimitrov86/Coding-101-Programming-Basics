using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ((i == 1)|| (i == n))
            {
                Console.Write("+");
                for (int j = 1; j <= n -2; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
            else if (i > 1 && i < n)
            {
                    Console.Write("|");
                    for (int l = 0; l < n - 2; l++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" |");
          }
        }
    }
}

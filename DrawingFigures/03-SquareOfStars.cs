using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j == 1)
                    Console.Write("*");
                else
                {
                    Console.Write(" *");
                }               
            }
            Console.WriteLine();
        }
    }
}

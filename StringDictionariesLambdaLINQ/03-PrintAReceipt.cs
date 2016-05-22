using System;
using System.Collections.Generic;
using System.Linq;
class PrintAReceipt
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int width = 24;
        double[] purchases = input.Split(' ').Select(double.Parse).ToArray();
        Console.WriteLine("/{0}\\", new string('-', width - 2));
        for (int i = 0; i < purchases.Length; i++)
        {
            Console.Write("|");
            Console.Write("{0, 21:f2}", purchases[i]);
            Console.WriteLine(" |");
        }
        Console.WriteLine("|{0}|", new string('-', width - 2));
        Console.WriteLine("| Total:{0, 14:f2} |", purchases.Sum());
        Console.WriteLine("\\{0}/", new string('-', width - 2));
    }
}
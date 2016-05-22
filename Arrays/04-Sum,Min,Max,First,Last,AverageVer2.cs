using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] sequence = new int[n];
        for (int i = 0; i < n; i++)
            sequence[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum = {0}", sequence.Sum());
        Console.WriteLine("Min = {0}", sequence.Min());
        Console.WriteLine("Max = {0}", sequence.Max());
        Console.WriteLine("First = {0}", sequence.First());
        Console.WriteLine("Last = {0}", sequence.Last());
        Console.WriteLine("Average = {0}", sequence.Average());
    }
}

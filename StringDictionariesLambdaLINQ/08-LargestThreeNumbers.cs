using System;
using System.Collections.Generic;
using System.Linq;
class LargestThreeNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> result = new List<int>();
        int maxCycleCount = Math.Min(3, numbers.Count);

        for (int i = 0; i < maxCycleCount; i++)
        {
            result.Add(numbers.Max());
            numbers.Remove(numbers.Max());
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
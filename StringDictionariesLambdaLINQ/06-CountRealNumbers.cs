using System;
using System.Collections.Generic;
using System.Linq;
class CountRealNumbers
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        SortedDictionary<double, int> occurences = new SortedDictionary<double, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (occurences.ContainsKey(numbers[i]))
                occurences[numbers[i]]++;
            else
                occurences.Add(numbers[i], 1);
        }
        foreach (var item in occurences)
            Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
    }
}
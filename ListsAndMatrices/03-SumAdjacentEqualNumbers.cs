using System;
using System.Collections.Generic;
using System.Linq;
class SumAdjacentEqualNumbers
{
    static void Main(string[] args)
    {
        List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i > 0 && numbers[i] == numbers[i - 1])
            {
                numbers[i-1] = numbers[i] + numbers[i-1];
                numbers.RemoveAt(i);
                i-=2;
            }
            else if (i < numbers.Count - 1 && numbers[i] == numbers[i + 1])
            {
                numbers[i] = numbers[i] + numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i--;
            }      
        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}
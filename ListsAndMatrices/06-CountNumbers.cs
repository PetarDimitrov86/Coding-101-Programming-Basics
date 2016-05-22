using System;
using System.Collections.Generic;
using System.Linq;
class CountNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        numbers.Sort();
        int counter = 1;
        for (int i = 0; i < numbers.Count - 1; i++)
        {

            if (numbers[i] == numbers[i + 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", numbers[i], counter);
                if (i != numbers.Count - 2)
                    counter = 1;
            }        
        }
        Console.WriteLine("{0} -> {1}", numbers[numbers.Count-1], counter);
    }
}

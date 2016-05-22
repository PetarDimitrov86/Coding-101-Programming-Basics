using System;
using System.Collections.Generic;
using System.Linq;
class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        List<int> originalNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> resultList = new List<int>();
        List<int> finalList = new List<int>();
        int counter = 1;
        int maxCounter = 1;
        resultList.Add(originalNumbers[0]);
        for (int i = 0; i < originalNumbers.Count - 1; i++)
        {
            if (originalNumbers[i] == originalNumbers[i+1])
            {
                counter++;
                resultList.Add(originalNumbers[i + 1]);
            }
            else
            {
                counter = 1;
                resultList.Clear();
                resultList.Add(originalNumbers[i+1]);
            }
            if (counter > maxCounter)
            {
                finalList.Clear();
                maxCounter = counter;
                finalList.AddRange(resultList);
            }
        }
        if (maxCounter == 1)
        {
            Console.WriteLine(originalNumbers[0]);
            return;
        }
        Console.WriteLine(string.Join(" ", finalList));
    }
}

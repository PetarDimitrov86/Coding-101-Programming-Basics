using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> originalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> positive = new List<int>();
        bool onlyPositive = false;
        for (int i = 0; i < originalList.Count; i++)
        {
            if (originalList[i] > 0)
            {
                positive.Add(originalList[i]);
                onlyPositive = true;
            }
        }
        positive.Reverse();
        if (onlyPositive == false)
            Console.WriteLine("empty");
        else if (onlyPositive == true)
            Console.WriteLine(string.Join(" ", positive));
    }
}

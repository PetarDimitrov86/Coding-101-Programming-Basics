using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> originalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for (int i = 0; i < originalList.Count; i++)
        {
            if (originalList[i] < 0)
            {
                originalList.RemoveAt(i);
                i--;            
            }
        }
        originalList.Reverse();
        if (originalList.Count == 0)
            Console.WriteLine("empty");
        else 
        Console.WriteLine(string.Join(" ", originalList));
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
class FoldAndSum
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = nums.Length / 4;
        int[] leftFirstRow = new int[length];
        leftFirstRow = nums.Take(length).Reverse().ToArray();
        int[] rightFirstRow = new int[length];
        rightFirstRow = nums.Reverse().Take(length).ToArray();
        List<int> firstRow = new List<int>();
        foreach (var item in leftFirstRow)
            firstRow.Add(item);
        foreach (var item in rightFirstRow)
            firstRow.Add(item);

        int[] secondRow = new int[nums.Length / 2];
        secondRow = nums.Skip(length).Take(length * 2).ToArray();

        int[] finalResult = new int[nums.Length / 2];
        for (int i = 0; i < finalResult.Length; i++)
            finalResult[i] = firstRow[i] + secondRow[i];
        Console.WriteLine(string.Join(" ", finalResult));
    }
}
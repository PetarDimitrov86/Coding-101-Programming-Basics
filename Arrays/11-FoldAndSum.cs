using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] foldedArray = new int[originalArray.Length / 2];
        int[] leftInsideArray = new int[originalArray.Length / 2];
        for (int i = 0; i < originalArray.Length/4; i++)
        {
            foldedArray[i] = originalArray[originalArray.Length/4 - i - 1];
            foldedArray[foldedArray.Length - i - 1] = originalArray[originalArray.Length - originalArray.Length / 4 + i];

            leftInsideArray[i] = originalArray[originalArray.Length / 4 + i];
            leftInsideArray[leftInsideArray.Length - i - 1] = originalArray[originalArray.Length - originalArray.Length / 4 - i - 1];
        }

        int[] summedArrays = new int[foldedArray.Length];
        for (int i = 0; i < foldedArray.Length; i++)
            summedArrays[i] = foldedArray[i] + leftInsideArray[i];

        Console.WriteLine(string.Join(" ", summedArrays));
    } 
}
